using GRT.SDK.Framework.Timer;
using Melsec.Helper.Interfaces;
using Melsec.Helper.Models;
using MelsecHelper.APP.Models;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MelsecHelper.APP.Services
{
   public class MoveOutService
   {
      #region Constant

      private const string AddrMoveOutRequestFlag = "LB0301";
      private const string AddrMoveOutResponseFlag = "LB0101";
      private const string AddrMoveOutTrackingData = "LW17B2";
      private const string AddrMoveOutReasonCode = "LW17BC";

      #endregion

      #region Fields

      private readonly AppPlcService _appPlcService;
      private readonly ICCLinkController _controller;
      private readonly Action<string> _logger;
      private readonly AppControllerSettings _settings;
      private readonly SynchronizationContext _syncContext;
      private readonly CTimer _timer = new CTimer();
      private bool _disposed;
      private CancellationTokenSource _moveOutCts;

      private Task _moveOutTask;
      private MoveOutData _pendingData;
      private int _step;

      #endregion

      #region Constructors

      public MoveOutService(AppPlcService appPlcService, AppControllerSettings settings, Action<string> logger = null)
      {
         _appPlcService = appPlcService ?? throw new ArgumentNullException(nameof(appPlcService));
         _controller = appPlcService.Controller ?? throw new ArgumentNullException(nameof(appPlcService.Controller));
         _logger = logger;
         _syncContext = SynchronizationContext.Current;
         _settings = settings;
      }

      #endregion

      #region Delegates, Events

      public event Action MoveOutCompleted;
      public event Action<string> MoveOutFailed;

      #endregion

      #region Public Methods

      public void Start()
      {
         _logger?.Invoke("[MoveOutService] Start() called");
         
         if (_moveOutTask != null)
         {
            _logger?.Invoke("[MoveOutService] Already started, skipping");
            return;
         }

         try
         {
            _logger?.Invoke("[MoveOutService] Creating CancellationTokenSource");
            _moveOutCts = new CancellationTokenSource();
            
            _logger?.Invoke($"[MoveOutService] Current SyncContext: {SynchronizationContext.Current?.GetType().Name ?? "null"}");
            _logger?.Invoke($"[MoveOutService] Default TaskScheduler: {TaskScheduler.Default.GetType().Name}");
            
            _logger?.Invoke("[MoveOutService] Creating background task with TaskScheduler.Default");
            _moveOutTask = Task.Factory.StartNew(
               () => MoveOutLoopAsync(_moveOutCts.Token),
               _moveOutCts.Token,
               TaskCreationOptions.LongRunning,
               TaskScheduler.Default
            ).Unwrap();
            
            _logger?.Invoke($"[MoveOutService] Task created, ID={_moveOutTask.Id}, Status={_moveOutTask.Status}");
            
            // 給 Task 一點時間啟動
            Task.Delay(10).Wait();
            _logger?.Invoke($"[MoveOutService] Task status after delay: {_moveOutTask.Status}");
            
            // 如果 Task 失敗，記錄異常
            if (_moveOutTask.Status == TaskStatus.Faulted)
            {
               _logger?.Invoke("[MoveOutService] *** Task is FAULTED! ***");
               if (_moveOutTask.Exception != null)
               {
                  foreach (var ex in _moveOutTask.Exception.InnerExceptions)
                  {
                     _logger?.Invoke($"[MoveOutService] Exception Type: {ex.GetType().Name}");
                     _logger?.Invoke($"[MoveOutService] Exception Message: {ex.Message}");
                     _logger?.Invoke($"[MoveOutService] Exception Stack: {ex.StackTrace}");
                  }
               }
            }
            
            _logger?.Invoke("[MoveOutService] Service Started");
         }
         catch (Exception ex)
         {
            _logger?.Invoke($"[MoveOutService] Start() Exception: {ex.GetType().Name}");
            _logger?.Invoke($"[MoveOutService] Message: {ex.Message}");
            _logger?.Invoke($"[MoveOutService] Stack: {ex.StackTrace}");
         }
      }

      public void Stop()
      {
         if (_moveOutCts != null)
         {
            _moveOutCts.Cancel();
            try
            {
               _moveOutTask?.Wait(500);
            }
            catch
            {
               // Ignore
            }

            _moveOutCts.Dispose();
            _moveOutCts = null;
            _moveOutTask = null;
         }

         _logger?.Invoke("[MoveOutService] Service Stopped");
      }

      public async Task StartMoveOut(MoveOutData data)
      {
         if (data == null)
         {
            throw new ArgumentNullException(nameof(data));
         }

         if (_step != 0)
         {
            _logger?.Invoke("[MoveOutService] Cannot start, busy (Step != 0)");
            return;
         }

         _pendingData = data;
         await Task.CompletedTask;
      }

      #endregion

      #region Private Methods

      private async Task MoveOutLoopAsync(CancellationToken ct)
      {
         _logger?.Invoke("[MoveOutService] MoveOutLoopAsync started");

         try
         {
            _logger?.Invoke("[MoveOutService] Entering main loop");

            while (!ct.IsCancellationRequested && !_disposed)
            {
               try
               {
                  _logger?.Invoke($"[MoveOutService] Loop - Step={_step}");

                  switch (_step)
                  {
                     case 0: // Idle
                        if (_pendingData != null)
                        {
                           _logger?.Invoke("[MoveOutService] Pending data detected, starting flow");
                           _step = 10;
                           _logger?.Invoke("[MoveOutService] Step: 0 -> 10");
                        }

                        break;

                     case 10: // Write Data & Set Request
                     {
                        _logger?.Invoke("[MoveOutService] Case 10: Writing data to PLC...");
                        // 1. Write Data (11 Words)
                        short[] rawData = _pendingData.ToRawData();
                        await _controller.WriteWordsAsync(AddrMoveOutTrackingData, rawData, ct);
                        _logger?.Invoke($"[MoveOutService] Data written to {AddrMoveOutTrackingData}");

                        // 2. Set Request ON
                        await _controller.WriteBitsAsync(AddrMoveOutRequestFlag, new[] { true }, ct);
                        _logger?.Invoke($"[MoveOutService] Request ON ({AddrMoveOutRequestFlag})");

                        _timer.Reset();
                        _step = 20;
                        _logger?.Invoke("[MoveOutService] Step: 10 -> 20, Timer Reset");
                     }

                     break;

                     case 20: // Wait Response ON
                     {
                        bool responseOn = _controller.GetBit(AddrMoveOutResponseFlag);
                        _logger?.Invoke($"[MoveOutService] Case 20: Waiting for Response ON, Current={responseOn}");

                        if (responseOn)
                        {
                           _logger?.Invoke($"[MoveOutService] Response ON ({AddrMoveOutResponseFlag}) detected");
                           _step = 30;
                           _logger?.Invoke("[MoveOutService] Step: 20 -> 30");
                        }
                        else if (_timer.On(_settings.MoveOut.T1Timeout))
                        {
                           _logger?.Invoke($"[MoveOutService] T1 Timeout occurred ({_settings.MoveOut.T1Timeout}ms)");
                           await AlarmHelper.AddAlarmCodeAsync(_appPlcService, "C010");
                           HandleError($"T1 Timeout:{_settings.MoveOut.T1Timeout} (Wait Response ON)");
                        }
                     }

                     break;

                     case 30: // Clear Request
                     {
                        _logger?.Invoke("[MoveOutService] Case 30: Clearing Request...");
                        await _controller.WriteBitsAsync(AddrMoveOutRequestFlag, new[] { false }, ct);
                        _logger?.Invoke($"[MoveOutService] Request OFF ({AddrMoveOutRequestFlag})");

                        _timer.Reset();
                        _step = 40;
                        _logger?.Invoke("[MoveOutService] Step: 30 -> 40, Timer Reset");
                     }

                     break;

                     case 40: // Wait Response OFF
                     {
                        bool responseOn = _controller.GetBit(AddrMoveOutResponseFlag);
                        _logger?.Invoke($"[MoveOutService] Case 40: Waiting for Response OFF, Current={responseOn}");

                        if (!responseOn)
                        {
                           _logger?.Invoke($"[MoveOutService] Response OFF ({AddrMoveOutResponseFlag}) detected - Flow Complete!");
                           HandleSuccess();
                           _logger?.Invoke("[MoveOutService] Step: 40 -> 0 (Success)");
                        }
                        else if (_timer.On(_settings.MoveOut.T2Timeout))
                        {
                           _logger?.Invoke($"[MoveOutService] T2 Timeout occurred ({_settings.MoveOut.T2Timeout}ms)");
                           await AlarmHelper.AddAlarmCodeAsync(_appPlcService, "C011");
                           HandleError($"T2 Timeout:{_settings.MoveOut.T2Timeout} (Wait Response OFF)");
                        }
                     }

                     break;
                  }

                  await Task.Delay(50, ct);
               }
               catch (OperationCanceledException ex)
               {
                  _logger?.Invoke($"[MoveOutService] Loop OperationCanceledException Error: {ex.Message}");
                  break;
               }
               catch (Exception ex)
               {
                  _logger?.Invoke($"[MoveOutService] Loop Exception Error: {ex.Message}");
                  await Task.Delay(1000, ct);
               }
            }
         }
         catch (Exception ex)
         {
            _logger?.Invoke($"[MoveOutService] MoveOutLoopAsync Exception Error: {ex.Message}");
         }
         finally
         {
            _logger?.Invoke("[MoveOutService] MoveOutLoopAsync ended");
         }
      }

      private async void HandleError(string message)
      {
         try
         {
            _logger?.Invoke($"[MoveOutService] Failed: {message}");

            // Reset Request Flag just in case
            await _controller.WriteBitsAsync(AddrMoveOutRequestFlag, new[] { false });

            _pendingData = null;
            _step = 0;
            PostEvent(() => MoveOutFailed?.Invoke(message));
         }
         catch
         {
            _logger?.Invoke($"[HandleError] Failed: {message}");
         }
      }

      private void HandleSuccess()
      {
         _pendingData = null;
         _step = 0;
         PostEvent(() => MoveOutCompleted?.Invoke());
      }

      private void PostEvent(Action action)
      {
         if (_syncContext != null)
         {
            _syncContext.Post(_ => action(), null);
         }
         else
         {
            action?.Invoke();
         }
      }

      #endregion
   }
}
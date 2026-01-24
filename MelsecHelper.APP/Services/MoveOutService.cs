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
         if (_moveOutTask != null)
         {
            return;
         }

         try
         {
            _moveOutCts = new CancellationTokenSource();
            _moveOutTask = Task.Factory.StartNew(
               () => MoveOutLoopAsync(_moveOutCts.Token),
               _moveOutCts.Token,
               TaskCreationOptions.LongRunning,
               TaskScheduler.Default
            ).Unwrap();

            _logger?.Invoke("[MoveOutService] Service Started");
         }
         catch (Exception ex)
         {
            _logger?.Invoke($"[MoveOutService] Start Exception: {ex.Message}");
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
            _logger?.Invoke("[MoveOutService] Busy (Step != 0)");
            return;
         }

         _pendingData = data;
         await Task.CompletedTask;
      }

      #endregion

      #region Private Methods

      private async Task MoveOutLoopAsync(CancellationToken ct)
      {
         try
         {
            while (!ct.IsCancellationRequested && !_disposed)
            {
               try
               {

                  switch (_step)
                  {
                     case 0: // Idle
                        if (_pendingData != null)
                        {
                           _step = 10;
                        }
                        break;

                     case 10: // Write Data & Set Request
                     {
                        // Write Data (11 Words)
                        short[] rawData = _pendingData.ToRawData();
                        await _controller.WriteWordsAsync(AddrMoveOutTrackingData, rawData, ct);

                        // Set Request ON
                        await _controller.WriteBitsAsync(AddrMoveOutRequestFlag, new[] { true }, ct);
                        _logger?.Invoke($"[MoveOutService] Request ON");

                        _timer.Reset();
                        _step = 20;
                     }
                     break;

                     case 20: // Wait Response ON
                     {
                        bool responseOn = _controller.GetBit(AddrMoveOutResponseFlag);

                        if (responseOn)
                        {
                           _logger?.Invoke($"[MoveOutService] Response ON");
                           _step = 30;
                        }
                        else if (_timer.On(_settings.MoveOut.T1Timeout))
                        {
                           _logger?.Invoke($"[MoveOutService] T1 Timeout ({_settings.MoveOut.T1Timeout}ms)");
                           await AlarmHelper.AddAlarmCodeAsync(_appPlcService, "C010");
                           HandleError($"T1 Timeout:{_settings.MoveOut.T1Timeout}");
                        }
                     }
                     break;

                     case 30: // Clear Request
                     {
                        await _controller.WriteBitsAsync(AddrMoveOutRequestFlag, new[] { false }, ct);
                        _logger?.Invoke($"[MoveOutService] Request OFF");

                        _timer.Reset();
                        _step = 40;
                     }
                     break;

                     case 40: // Wait Response OFF
                     {
                        bool responseOn = _controller.GetBit(AddrMoveOutResponseFlag);

                        if (!responseOn)
                        {
                           _logger?.Invoke($"[MoveOutService] Response OFF - Complete!");
                           HandleSuccess();
                        }
                        else if (_timer.On(_settings.MoveOut.T2Timeout))
                        {
                           _logger?.Invoke($"[MoveOutService] T2 Timeout ({_settings.MoveOut.T2Timeout}ms)");
                           await AlarmHelper.AddAlarmCodeAsync(_appPlcService, "C011");
                           HandleError($"T2 Timeout:{_settings.MoveOut.T2Timeout}");
                        }
                     }
                     break;
                  }

                  await Task.Delay(50, ct);
               }
               catch (OperationCanceledException)
               {
                  break;
               }
               catch (Exception ex)
               {
                  _logger?.Invoke($"[MoveOutService] Loop Exception: {ex.Message}");
                  await Task.Delay(1000, ct);
               }
            }
         }
         catch (Exception ex)
         {
            _logger?.Invoke($"[MoveOutService] Exception: {ex.Message}");
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
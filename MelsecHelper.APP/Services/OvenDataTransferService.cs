using Melsec.Helper.Interfaces;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MelsecHelper.APP.Services
{
   /// <summary>
   /// 烤箱資料轉拋服務 (Task Loop Version)
   /// </summary>
   public class OvenDataTransferService : IDisposable
   {
      #region Constant

      // 寫入起始位址 0x119E = LW119E
      private const string DEST_START_ADDRESS = "LW119E";
      private const int TOTAL_WORDS = 520;

      #endregion

      #region Fields

      // 資料來源委派：一個非同步方法，回傳 short[]
      private readonly Func<Task<short[]>> _dataSourceReader;
      private readonly ICCLinkController _destination;
      private readonly Action<string> _logger;

      private bool _disposed = false;

      private int _intervalMs = 30000;
      private bool _isRunning = false;

      // 緩存上次成功的資料 (錯誤處理)
      private short[] _lastSuccessData;
      private CancellationTokenSource _loopCts;
      private Task _loopTask;

      #endregion

      #region Constructors

      /// <summary>
      /// 建構子
      /// </summary>
      /// <param name="dataSourceReader">資料讀取委派</param>
      /// <param name="dest">PLC 控制器</param>
      /// <param name="logger">日誌委派</param>
      public OvenDataTransferService(Func<Task<short[]>> dataSourceReader, ICCLinkController dest, Action<string> logger = null)
      {
         _dataSourceReader = dataSourceReader ?? throw new ArgumentNullException(nameof(dataSourceReader));
         _destination = dest ?? throw new ArgumentNullException(nameof(dest));
         _logger = logger ?? (msg => Console.WriteLine($"[OvenService] {DateTime.Now:HH:mm:ss}: {msg}"));
      }

      #endregion

      #region Properties

      /// <summary>
      /// 上報間隔 (毫秒)
      /// </summary>
      public int Interval
      {
         get => _intervalMs;
         set => _intervalMs = Math.Max(1000, value);
      }

      #endregion

      #region Public Methods

      /// <summary>
      /// 啟動服務
      /// </summary>
      /// <param name="intervalMs">初始間隔 (毫秒)</param>
      public void Start(int intervalMs)
      {
         if (_disposed)
         {
            throw new ObjectDisposedException(nameof(OvenDataTransferService));
         }

         Interval = intervalMs;
         Start();
      }

      /// <summary>
      /// 啟動服務 (使用當前間隔)
      /// </summary>
      public void Start()
      {
         if (_disposed)
         {
            throw new ObjectDisposedException(nameof(OvenDataTransferService));
         }

         if (_isRunning)
         {
            return;
         }

         _isRunning = true;
         _loopCts = new CancellationTokenSource();
         // 啟動背景迴圈
         _loopTask = Task.Run(() => TransferLoopAsync(_loopCts.Token));
      }

      /// <summary>
      /// 停止服務
      /// </summary>
      public void Stop()
      {
         _isRunning = false;
         _loopCts?.Cancel();
      }

      /// <summary>
      /// 取得配方編號 (輔助方法)
      /// </summary>
      public ushort GetRecipeNo(short[] data, int ovenIndex) => (ushort)data[ovenIndex * 65 + 0];

      /// <summary>
      /// 取得爐狀態 (輔助方法)
      /// </summary>
      public ushort GetOvenStatus(short[] data, int ovenIndex) => (ushort)data[ovenIndex * 65 + 1];

      /// <summary>
      /// 取得連線狀態 (輔助方法)
      /// </summary>
      public ushort GetConnectionStatus(short[] data, int ovenIndex) => (ushort)data[ovenIndex * 65 + 2];

      #endregion

      #region Private Methods

      private async Task TransferLoopAsync(CancellationToken token)
      {
         Log("服務迴圈已啟動");

         while (!token.IsCancellationRequested)
         {
            try
            {
               await DoTransferAsync();
            }
            catch (Exception ex)
            {
               Log($"轉拋過程發生例外: {ex.Message}");
            }

            try
            {
               // 等待間隔 (支援取消)
               int delay = Math.Max(1000, _intervalMs);
               await Task.Delay(delay, token);
            }
            catch (OperationCanceledException)
            {
               Log("服務迴圈已取消");
               break;
            }
         }

         _isRunning = false;
         Log("服務迴圈已結束");
      }

      private async Task DoTransferAsync()
      {
         short[] dataToWrite = null;
         try
         {
            // 讀取資料 (透過委派)
            var newData = await _dataSourceReader();

            if (newData != null && newData.Length == TOTAL_WORDS)
            {
               _lastSuccessData = newData;
               dataToWrite = newData;
            }
            else
            {
               // 讀取失敗，使用上次資料
               dataToWrite = _lastSuccessData;
               Log("讀取資料長度錯誤或為null，使用上次緩存");
            }
         }
         catch (Exception ex)
         {
            dataToWrite = _lastSuccessData;
            Log($"讀取資料異常: {ex.Message}，使用上次緩存");
         }

         // 寫入資料
         if (dataToWrite != null)
         {
            try
            {
               await _destination.WriteWordsAsync(DEST_START_ADDRESS, dataToWrite);
               Log("CCLink 寫入成功");
            }
            catch (Exception ex)
            {
               Log($"CCLink 寫入失敗: {ex.Message}");
            }
         }
      }

      private void Log(string msg) => _logger?.Invoke(msg);

      #endregion

      public void Dispose()
      {
         if (!_disposed)
         {
            Stop();
            _loopCts?.Dispose();
            _disposed = true;
         }

         GC.SuppressFinalize(this);
      }
   }
}
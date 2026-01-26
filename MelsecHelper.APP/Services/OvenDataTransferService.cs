using Melsec.Helper.Interfaces;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MelsecHelper.APP.Services
{
   /// <summary>
   /// 烤箱資料轉拋服務
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
      private readonly int _intervalMs = 30000;
      private readonly Timer _timer;
      private bool _disposed = false;

      // 緩存上次成功的資料 (錯誤處理)
      private short[] _lastSuccessData;

      #endregion

      #region Constructors

      /// <summary>
      /// 建構子
      /// </summary>
      /// <param name="dataSourceReader">資料讀取委派</param>
      /// <param name="dest">PLC 控制器</param>
      public OvenDataTransferService(Func<Task<short[]>> dataSourceReader, ICCLinkController dest)
      {
         _dataSourceReader = dataSourceReader ?? throw new ArgumentNullException(nameof(dataSourceReader));
         _destination = dest ?? throw new ArgumentNullException(nameof(dest));

         // 使用 Timeout.Infinite 防止建構時自動啟動
         _timer = new Timer(OnTimerElapsed, null, Timeout.Infinite, Timeout.Infinite);
      }

      #endregion

      #region Public Methods

      /// <summary>
      /// 啟動服務
      /// </summary>
      public void Start()
      {
         if (_disposed)
         {
            throw new ObjectDisposedException(nameof(OvenDataTransferService));
         }

         _timer.Change(0, _intervalMs); // 立即執行，然後每 30 秒
      }

      /// <summary>
      /// 停止服務
      /// </summary>
      public void Stop()
      {
         _timer.Change(Timeout.Infinite, Timeout.Infinite);
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

      private async void OnTimerElapsed(object state)
      {
         if (_disposed)
         {
            return;
         }

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
               Log("讀取長度錯誤或為null，使用上次資料");
            }
         }
         catch (Exception ex)
         {
            dataToWrite = _lastSuccessData;
            Log($"讀取異常: {ex.Message}，使用上次資料");
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

      private void Log(string msg) => Console.WriteLine($"[OvenService] {DateTime.Now}: {msg}");

      #endregion

      public void Dispose()
      {
         if (!_disposed)
         {
            _timer?.Dispose();
            _disposed = true;
         }
      }
   }
}
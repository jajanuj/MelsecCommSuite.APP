using Melsec.Helper.Interfaces;
using MelsecHelper.APP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MelsecHelper.APP.Services
{
   /// <summary>
   /// 追蹤資料管理服務
   /// </summary>
   public class TrackingDataService
   {
      #region Fields

      private readonly StationTrackingConfig _config;

      private readonly ICCLinkController _controller;

      /// <summary>
      /// 站別流程順序對應表 (Key: 當前站別ID, Value: 前一站別ID，0表示無前站)
      /// </summary>
      private readonly Dictionary<int, int> _stationSequence = new Dictionary<int, int>
      {
         { 1, 0 },   // 上游平台 (第一站)
         { 2, 1 },   // 插框機手臂
         { 3, 2 },   // 插框站
         { 4, 3 },   // 插框機出料
         { 5, 4 },   // RGV
         { 6, 5 },   // 烤箱1
         { 7, 6 },   // 烤箱2
         { 8, 7 },   // 烤箱3
         { 9, 8 },   // 烤箱4
         { 10, 9 },  // 烤箱5
         { 11, 10 }, // 烤箱6
         { 12, 11 }, // 烤箱7
         { 13, 12 }, // 烤箱8
         { 14, 13 }, // 拆框機入料
         { 15, 14 }, // 拆框機入料平台
         { 16, 15 }, // 拆框機移載預備
         { 17, 16 }, // 拆框機移載完成
         { 18, 17 }, // 拆框機出料平台
         { 19, 18 }, // 拆框站
         { 20, 19 }, // 拆框機出料
         { 21, 20 }, // 拆框機手臂
         { 22, 21 }, // 下游平台
         { 23, 22 }  // 手動口
      };

      #endregion

      #region Constructors

      /// <summary>
      /// 建構子
      /// </summary>
      /// <param name="controller">PLC 控制器</param>
      /// <param name="configPath">配置檔路徑</param>
      public TrackingDataService(ICCLinkController controller, string configPath)
      {
         _controller = controller ?? throw new ArgumentNullException(nameof(controller));

         try
         {
            _config = StationTrackingConfig.LoadFromFile(configPath);
         }
         catch (Exception ex)
         {
            throw new InvalidOperationException($"初始化追蹤資料服務失敗: {ex.Message}", ex);
         }
      }

      /// <summary>
      /// 建構子 (直接傳入配置物件)
      /// </summary>
      /// <param name="controller">PLC 控制器</param>
      /// <param name="config">站別追蹤配置</param>
      public TrackingDataService(ICCLinkController controller, StationTrackingConfig config)
      {
         _controller = controller ?? throw new ArgumentNullException(nameof(controller));
         _config = config ?? throw new ArgumentNullException(nameof(config));
      }

      #endregion

      #region Public Methods

      /// <summary>
      /// 更新指定站的單一位置追蹤資料
      /// </summary>
      /// <param name="stationId">站號 (1-22)</param>
      /// <param name="slotIndex">站內位置索引 (1-based, 1~容量)</param>
      /// <param name="data">追蹤資料</param>
      /// <param name="ct">取消令牌</param>
      /// <returns>是否成功</returns>
      public async Task<bool> UpdateSingleSlotAsync(int stationId, int slotIndex, TrackingData data, CancellationToken ct = default)
      {
         try
         {
            // 驗證參數
            ValidateStationAndSlot(stationId, slotIndex, out StationConfig station);

            if (data == null)
            {
               throw new ArgumentNullException(nameof(data), "追蹤資料不可為 null");
            }

            // 計算目標 Address
            string targetAddress = station.CalculateSlotAddress(slotIndex);

            // 寫入 PLC
            short[] rawData = data.ToRawData();
            await _controller.WriteWordsAsync(targetAddress, rawData, ct);

            return true;
         }
         catch (Exception ex)
         {
            ShowError($"更新站別 {stationId} 位置 {slotIndex} 失敗", ex);
            return false;
         }
      }

      /// <summary>
      /// 將來源站的所有追蹤資料複製到目標站
      /// </summary>
      /// <param name="fromStationId">來源站號</param>
      /// <param name="toStationId">目標站號</param>
      /// <param name="ct">取消令牌</param>
      /// <returns>是否成功</returns>
      public async Task<bool> TransferStationDataAsync(int fromStationId, int toStationId, CancellationToken ct = default)
      {
         try
         {
            // 驗證站別
            var fromStation = GetStationOrThrow(fromStationId);
            var toStation = GetStationOrThrow(toStationId);

            // 檢查容量是否一致 (方案 B: 嚴格檢查)
            if (fromStation.Capacity != toStation.Capacity)
            {
               throw new InvalidOperationException(
                  $"站別容量不一致，無法轉移資料。\n" +
                  $"來源站 {fromStationId} ({fromStation.StationName}): {fromStation.Capacity} 片\n" +
                  $"目標站 {toStationId} ({toStation.StationName}): {toStation.Capacity} 片");
            }

            // 批次讀取來源站所有資料
            int totalWords = fromStation.GetTotalDataLength();
            var allData = await _controller.ReadWordsAsync(fromStation.StartAddress, totalWords, ct);

            // 批次寫入目標站
            await _controller.WriteWordsAsync(toStation.StartAddress, allData, ct);

            return true;
         }
         catch (Exception ex)
         {
            ShowError($"站別轉移失敗 (站別 {fromStationId} → {toStationId})", ex);
            return false;
         }
      }

      /// <summary>
      /// 更新單片容量站的追蹤資料 (容量=1的站)
      /// </summary>
      /// <param name="stationId">站號</param>
      /// <param name="data">追蹤資料</param>
      /// <param name="ct">取消令牌</param>
      /// <returns>是否成功</returns>
      public async Task<bool> UpdateSingleCapacityStationAsync(int stationId, TrackingData data, CancellationToken ct = default)
      {
         try
         {
            var station = GetStationOrThrow(stationId);

            // 驗證是否為單片站
            if (station.Capacity != 1)
            {
               throw new InvalidOperationException(
                  $"站別 {stationId} ({station.StationName}) 的容量為 {station.Capacity} 片，不是單片站。\n" +
                  $"請使用 UpdateSingleSlotAsync 方法。");
            }

            if (data == null)
            {
               throw new ArgumentNullException(nameof(data), "追蹤資料不可為 null");
            }

            // 寫入 PLC (單片站直接使用起始 Address)
            short[] rawData = data.ToRawData();
            await _controller.WriteWordsAsync(station.StartAddress, rawData, ct);

            return true;
         }
         catch (Exception ex)
         {
            ShowError($"更新單片站 {stationId} 失敗", ex);
            return false;
         }
      }

      /// <summary>
      /// 根據站號和站內位置索引讀取追蹤資料
      /// </summary>
      /// <param name="stationId">站號 (1-22)</param>
      /// <param name="slotIndex">站內位置索引 (1-based, 1~容量)</param>
      /// <param name="ct">取消令牌</param>
      /// <returns>追蹤資料，失敗時返回 null</returns>
      public async Task<TrackingData> ReadSlotDataAsync(int stationId, int slotIndex, CancellationToken ct = default)
      {
         try
         {
            // 驗證參數
            ValidateStationAndSlot(stationId, slotIndex, out StationConfig station);

            // 計算目標 Address
            string targetAddress = station.CalculateSlotAddress(slotIndex);

            // 讀取 PLC (10 words)
            var rawData = await _controller.ReadWordsAsync(targetAddress, 10, ct);

            // 轉換為 TrackingData
            return TrackingData.FromRawData(rawData.ToArray());
         }
         catch (Exception ex)
         {
            ShowError($"讀取站別 {stationId} 位置 {slotIndex} 失敗", ex);
            return null;
         }
      }

      /// <summary>
      /// 讀取整站的所有追蹤資料
      /// </summary>
      /// <param name="stationId">站號</param>
      /// <param name="ct">取消令牌</param>
      /// <returns>追蹤資料列表，失敗時返回 null</returns>
      public async Task<List<TrackingData>> ReadStationDataAsync(int stationId, CancellationToken ct = default)
      {
         try
         {
            var station = GetStationOrThrow(stationId);

            // 批次讀取整站資料
            int totalWords = station.GetTotalDataLength();
            var allData = await _controller.ReadWordsAsync(station.StartAddress, totalWords, ct);

            // 轉換為 TrackingData 列表
            var result = new List<TrackingData>();
            for (int i = 0; i < station.Capacity; i++)
            {
               var slotData = allData.Skip(i * 10).Take(10).ToArray();
               result.Add(TrackingData.FromRawData(slotData));
            }

            return result;
         }
         catch (Exception ex)
         {
            ShowError($"讀取站別 {stationId} 所有資料失敗", ex);
            return null;
         }
      }

      /// <summary>
      /// 取得所有站別配置
      /// </summary>
      public IReadOnlyList<StationConfig> GetAllStations()
      {
         return _config.Stations.AsReadOnly();
      }

      /// <summary>
      /// 取得指定站別配置
      /// </summary>
      public StationConfig GetStation(int stationId)
      {
         return _config.GetStation(stationId);
      }

      /// <summary>
      /// 根據起始位址清除追蹤資料（寫入 0 值）
      /// </summary>
      /// <param name="address">PLC 起始位址（例如：LW1868）</param>
      /// <param name="ct">取消令牌</param>
      /// <returns>是否成功</returns>
      public async Task<bool> ClearDataByAddressAsync(string address, CancellationToken ct = default)
      {
         try
         {
            // 驗證位址格式
            if (string.IsNullOrWhiteSpace(address))
            {
               throw new ArgumentException("位址不可為空白", nameof(address));
            }

            // 正規表達式驗證：LW + 4位十六進位
            if (!System.Text.RegularExpressions.Regex.IsMatch(address, @"^LW[0-9A-Fa-f]{4}$"))
            {
               throw new ArgumentException(
                  $"位址格式錯誤: '{address}'\\n" +
                  $"正確格式應為 LW + 4位十六進位數字（例如：LW1868）",
                  nameof(address));
            }

            // 建立零值資料 (10 words)
            short[] zeroData = new short[10];

            // 寫入 PLC
            await _controller.WriteWordsAsync(address.ToUpper(), zeroData, ct);

            return true;
         }
         catch (Exception ex)
         {
            ShowError($"清除位址 {address} 的資料失敗", ex);
            return false;
         }
      }

      /// <summary>
      /// 處理 MoveOut 後的 Last Flag 傳遞邏輯（支援跨站別）
      /// </summary>
      /// <param name="clearedAddress">被清除的位址</param>
      /// <param name="ct">取消令牌</param>
      public async Task HandleLastFlagTransferAsync(string clearedAddress, CancellationToken ct = default)
      {
         try
         {
            // 1. 讀取被清除位址的資料
            var clearedData = await ReadDataByAddressAsync(clearedAddress, ct);

            // 2. 檢查 Last Flag
            if (!clearedData.IsLastFlag)
            {
               return; // 不是最後一片，無需處理
            }

            // 3. 找到該位址對應的 station 和 slot
            var (currentStationId, currentSlot) = FindStationAndSlot(clearedAddress);
            var currentStation = _config.GetStation(currentStationId);

            // 4. 檢查同站是否還有其他片（從後往前找）
            for (int slot = currentSlot - 1; slot >= 1; slot--)
            {
               string address = currentStation.CalculateSlotAddress(slot);
               var data = await ReadDataByAddressAsync(address, ct);

               // 找到有資料的片（BoardId 不為空）
               if (!IsEmptyData(data))
               {
                  // 設定同站前一片的 Last Flag
                  data.SetLastFlag(true);
                  await _controller.WriteWordsAsync(address, data.ToRawData(), ct);
                  return;
               }
            }

            // 5. 同站沒有其他片，找下一個站別（後站）的第一片
            int? nextStationId = GetNextStationId(currentStationId);
            if (nextStationId == null)
            {
               return; // 已是最後一站，無後站
            }

            // 6. 在後站找第一片（從前往後找）
            var nextStation = _config.GetStation(nextStationId.Value);
            for (int slot = 1; slot <= nextStation.Capacity; slot++)
            {
               string address = nextStation.CalculateSlotAddress(slot);
               var data = await ReadDataByAddressAsync(address, ct);

               if (!IsEmptyData(data))
               {
                  // 設定後站第一片的 Last Flag
                  data.SetLastFlag(true);
                  await _controller.WriteWordsAsync(address, data.ToRawData(), ct);
                  return;
               }
            }
         }
         catch (Exception ex)
         {
            ShowError($"處理 Last Flag 傳遞失敗 (位址: {clearedAddress})", ex);
         }
      }

      #endregion

      #region Private Methods

      /// <summary>
      /// 檢查追蹤資料是否為空（無板號）
      /// </summary>
      private bool IsEmptyData(TrackingData data)
      {
         return data.BoardId[0] == 0 && data.BoardId[1] == 0 && data.BoardId[2] == 0;
      }

      /// <summary>
      /// 取得前一個站別 ID
      /// </summary>
      private int? GetPreviousStationId(int currentStationId)
      {
         if (_stationSequence.TryGetValue(currentStationId, out int previousId))
         {
            return previousId == 0 ? null : (int?)previousId;
         }

         return null;
      }

      /// <summary>
      /// 取得下一個站別 ID（後站）
      /// </summary>
      private int? GetNextStationId(int currentStationId)
      {
         // 在字典中找哪個站別的前站是 currentStationId
         foreach (var kvp in _stationSequence)
         {
            if (kvp.Value == currentStationId)
            {
               return kvp.Key;
            }
         }

         return null; // 沒有下一站
      }

      /// <summary>
      /// 根據位址反查 station 和 slot
      /// </summary>
      private (int stationId, int slotIndex) FindStationAndSlot(string address)
      {
         string hexPart = address.Substring(2); // "LW1868" -> "1868"
         int addressValue = Convert.ToInt32(hexPart, 16);

         foreach (var station in _config.Stations)
         {
            int baseAddress = ParseAddress(station.StartAddress);
            int maxAddress = baseAddress + station.Capacity * 10;

            if (addressValue >= baseAddress && addressValue < maxAddress)
            {
               int offset = addressValue - baseAddress;
               int slotIndex = offset / 10 + 1;
               return (station.StationId, slotIndex);
            }
         }

         throw new InvalidOperationException($"無法找到位址 {address} 對應的站別");
      }

      /// <summary>
      /// 解析 PLC 位址為數值
      /// </summary>
      private int ParseAddress(string address)
      {
         string hexPart = address.Substring(2);
         return Convert.ToInt32(hexPart, 16);
      }

      /// <summary>
      /// 根據位址讀取追蹤資料
      /// </summary>
      private async Task<TrackingData> ReadDataByAddressAsync(string address, CancellationToken ct)
      {
         var data = await _controller.ReadWordsAsync(address, 10, ct);
         return TrackingData.FromRawData(data.ToArray());
      }

      /// <summary>
      /// 驗證站號和位置索引
      /// </summary>
      private void ValidateStationAndSlot(int stationId, int slotIndex, out StationConfig station)
      {
         station = GetStationOrThrow(stationId);

         if (!station.IsValidSlotIndex(slotIndex))
         {
            throw new ArgumentOutOfRangeException(nameof(slotIndex),
               $"位置索引 {slotIndex} 超出站別 {stationId} ({station.StationName}) 的容量範圍 (1-{station.Capacity})");
         }
      }

      /// <summary>
      /// 取得站別配置，若不存在則拋出例外
      /// </summary>
      private StationConfig GetStationOrThrow(int stationId)
      {
         var station = _config.GetStation(stationId);
         if (station == null)
         {
            throw new ArgumentException($"站號 {stationId} 不存在，有效範圍: 1-22", nameof(stationId));
         }

         return station;
      }

      /// <summary>
      /// 顯示錯誤訊息
      /// </summary>
      private void ShowError(string title, Exception ex)
      {
         string message = $"{title}\n\n錯誤訊息: {ex.Message}";
         MessageBox.Show(message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }

      #endregion
   }
}
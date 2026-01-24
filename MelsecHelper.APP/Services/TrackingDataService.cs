using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Melsec.Helper.Interfaces;
using MelsecHelper.APP.Models;

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

      #endregion

      #region Private Methods

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
         MessageBox.Show(message, "追蹤資料管理錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }

      #endregion
   }
}
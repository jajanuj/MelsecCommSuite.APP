using MelsecHelper.APP.Models;
using System.Collections.Generic;

namespace MelsecHelper.APP.Services
{
   /// <summary>
   /// 混載檢查結果
   /// </summary>
   public enum LotMixingResult
   {
      OK,
      DifferentLot,
      EmptyList,
      Disabled
   }

   /// <summary>
   /// 批號變更處理動作
   /// </summary>
   public enum LotChangeAction
   {
      /// <summary>變更母框（繼續加入新批號）</summary>
      ChangeLot,

      /// <summary>基板排出（取消加入）</summary>
      EjectBoard,

      /// <summary>取消操作</summary>
      Cancel
   }

   /// <summary>
   /// 防混批檢查服務
   /// </summary>
   public class LotMixingService
   {
      /// <summary>
      /// 檢查是否啟用混載檢查
      /// </summary>
      public bool IsEnabled { get; set; } = true;

      /// <summary>
      /// 檢查批號混批情況
      /// </summary>
      /// <param name="newData">新加入的追蹤資料</param>
      /// <param name="currentList">目前清單中的資料</param>
      /// <returns>檢查結果</returns>
      public LotMixingResult CheckLotMixing(TrackingData newData, IList<TrackingData> currentList)
      {
         // 如果未啟用混批檢查，直接允許
         if (!IsEnabled)
         {
            return LotMixingResult.Disabled;
         }

         // 如果列表為空，直接允許
         if (currentList == null || currentList.Count == 0)
         {
            return LotMixingResult.EmptyList;
         }

         // 取得最後一筆資料
         var lastData = currentList[currentList.Count - 1];

         // 比對批號（LotNoChar 和 LotNoNum）
         bool isDifferentLot = lastData.LotNoChar != newData.LotNoChar ||
                               lastData.LotNoNum != newData.LotNoNum;

         if (isDifferentLot)
         {
            return LotMixingResult.DifferentLot;
         }

         return LotMixingResult.OK;
      }

      /// <summary>
      /// 格式化批號顯示字串
      /// </summary>
      public string FormatLotNo(TrackingData data)
      {
         return $"{(char)data.LotNoChar}{data.LotNoNum:D8}";
      }
   }
}

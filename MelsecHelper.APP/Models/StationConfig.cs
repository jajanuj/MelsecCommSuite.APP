using System;

namespace MelsecHelper.APP.Models
{
   /// <summary>
   /// 站別配置資訊
   /// </summary>
   [Serializable]
   public class StationConfig
   {
      #region Properties

      /// <summary>
      /// 站號 (1-22)
      /// </summary>
      public int StationId { get; set; }

      /// <summary>
      /// 站點名稱
      /// </summary>
      public string StationName { get; set; }

      /// <summary>
      /// 容量 (片數)
      /// </summary>
      public int Capacity { get; set; }

      /// <summary>
      /// 起始 Address (十六進位字串，例如: "LW184A")
      /// </summary>
      public string StartAddress { get; set; }

      /// <summary>
      /// 全域起始編號 (橘色標記)
      /// </summary>
      public int GlobalStartIndex { get; set; }

      /// <summary>
      /// 全域結束編號 (橘色標記)
      /// </summary>
      public int GlobalEndIndex { get; set; }

      #endregion

      #region Public Methods

      /// <summary>
      /// 計算指定位置的 Address
      /// </summary>
      /// <param name="slotIndex">站內位置索引 (1-based, 1~Capacity)</param>
      /// <returns>計算後的 Address 字串</returns>
      public string CalculateSlotAddress(int slotIndex)
      {
         if (!IsValidSlotIndex(slotIndex))
         {
            throw new ArgumentOutOfRangeException(nameof(slotIndex),
               $"位置索引 {slotIndex} 超出站別 {StationId} 的容量範圍 (1-{Capacity})");
         }

         // 解析起始 Address (例如: "LW184A" -> 0x184A)
         string hexPart = StartAddress.Substring(2); // 移除 "LW" 前綴
         int baseAddress = Convert.ToInt32(hexPart, 16);

         // 計算目標 Address: 起始 + (位置索引-1) × 10
         int targetAddress = baseAddress + (slotIndex - 1) * 10;

         // 轉回 "LW" + 十六進位格式
         return $"LW{targetAddress:X4}";
      }

      /// <summary>
      /// 驗證位置索引是否有效
      /// </summary>
      /// <param name="slotIndex">站內位置索引 (1-based)</param>
      /// <returns>是否有效</returns>
      public bool IsValidSlotIndex(int slotIndex)
      {
         return slotIndex >= 1 && slotIndex <= Capacity;
      }

      /// <summary>
      /// 取得站別的總資料長度 (Words)
      /// </summary>
      public int GetTotalDataLength()
      {
         return Capacity * 10; // 每片 10 words
      }

      #endregion
   }
}
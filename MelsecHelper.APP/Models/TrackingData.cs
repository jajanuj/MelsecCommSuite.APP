using System;
using System.Collections.Generic;

namespace MelsecHelper.APP.Models
{
   /// <summary>
   /// 追蹤資料模型，對應 PLC 10 Words 結構。
   /// </summary>
   public class TrackingData
   {
      #region Constructors

      /// <summary>
      /// 預設建構子
      /// </summary>
      public TrackingData()
      {
      }

      /// <summary>
      /// 從 PLC 讀取的原始資料建構 (IList&lt;short&gt; 或陣列)
      /// </summary>
      /// <param name="rawData">10 個 Word 的陣列</param>
      public TrackingData(IList<short> rawData)
      {
         if (rawData == null || rawData.Count < 10)
         {
            throw new ArgumentException("rawData 必須至少包含 10 個元素");
         }

         BoardId[0] = (ushort)rawData[0];
         BoardId[1] = (ushort)rawData[1];
         BoardId[2] = (ushort)rawData[2];
         LayerCount = (ushort)rawData[3];
         LotNoChar = (ushort)rawData[4];

         // Offset 5-6 組成 32-bit uint (Little Endian: Low Word first)
         LotNoNum = (uint)((ushort)rawData[5] | ((ushort)rawData[6] << 16));

         JudgeFlag1 = (ushort)rawData[7];
         JudgeFlag2 = (ushort)rawData[8];
         JudgeFlag3 = (ushort)rawData[9];
      }

      #endregion

      #region Properties

      /// <summary>
      /// 起始位址
      /// </summary>
      public string StartAddress { get; set; }

      /// <summary>
      /// 基板序號 (Offset 0-2, 3 Words)
      /// </summary>
      public ushort[] BoardId { get; set; } = new ushort[3];

      /// <summary>
      /// 基板層數 (Offset 3)
      /// </summary>
      public ushort LayerCount { get; set; }

      /// <summary>
      /// 批號文字部分 (Offset 4)
      /// </summary>
      public ushort LotNoChar { get; set; }

      /// <summary>
      /// 批號數字部分 (Offset 5-6, 2 Words 組成 32-bit)
      /// </summary>
      public uint LotNoNum { get; set; }

      /// <summary>
      /// 判斷旗標 1 (Offset 7)
      /// </summary>
      public ushort JudgeFlag1 { get; set; }

      /// <summary>
      /// 判斷旗標 2 (Offset 8)
      /// </summary>
      public ushort JudgeFlag2 { get; set; }

      /// <summary>
      /// 判斷旗標 3 (Offset 9)
      /// </summary>
      public ushort JudgeFlag3 { get; set; }

      /// <summary>
      /// OK/NG/PD 判斷結果 (JudgeFlag2 Bit 15-14)
      /// </summary>
      public JudgmentResult Result
      {
         get => (JudgmentResult)((JudgeFlag2 >> 14) & 0x03);
      }

      /// <summary>
      /// 最後一片旗標 (JudgeFlag2 Bit 13)
      /// </summary>
      /// <summary>
      /// 最後一片旗標 (JudgeFlag2 Bit 13)
      /// </summary>
      public bool IsLastFlag
      {
         get => ((JudgeFlag2 >> 13) & 0x01) == 1;
      }

      /// <summary>
      /// 配方編號
      /// </summary>
      public ushort RecipeNo { get; set; }

      #endregion

      #region Public Methods

      /// <summary>
      /// 資料是否有效 (BoardId 不全為 0)
      /// </summary>
      public bool IsValid()
      {
         return BoardId != null && (BoardId[0] != 0 || BoardId[1] != 0 || BoardId[2] != 0);
      }

      /// <summary>
      /// 轉換為 short 陣列以寫入 PLC
      /// </summary>
      public short[] ToRawData()
      {
         return new short[10]
         {
            (short)BoardId[0],
            (short)BoardId[1],
            (short)BoardId[2],
            (short)LayerCount,
            (short)LotNoChar,
            (short)(LotNoNum & 0xFFFF),         // Low Word
            (short)((LotNoNum >> 16) & 0xFFFF), // High Word
            (short)JudgeFlag1,
            (short)JudgeFlag2,
            (short)JudgeFlag3
         };
      }

      /// <summary>
      /// 格式化顯示基板序號
      /// </summary>
      public string FormatBoardId() => $"{BoardId[2]:X4}-{BoardId[1]:X4}-{BoardId[0]:X4}";

      /// <summary>
      /// 格式化顯示批號
      /// </summary>
      public string FormatLotNo() => $"{(char)LotNoChar}{LotNoNum:D8}";

      /// <summary>
      /// 從 PLC 原始資料建立 TrackingData
      /// </summary>
      public static TrackingData FromRawData(short[] data)
      {
         if (data == null || data.Length < 10)
         {
            return new TrackingData();
         }

         return new TrackingData(data);
      }

      /// <summary>
      /// 從 ushort 陣列建立 TrackingData（用於維護資料接收）
      /// </summary>
      /// <param name="words">10 個 Word 的 ushort 陣列</param>
      public static TrackingData FromWords(ushort[] words)
      {
         if (words == null || words.Length < 10)
         {
            return new TrackingData();
         }

         return new TrackingData
         {
            BoardId = new ushort[] { words[0], words[1], words[2] },
            LayerCount = words[3],
            LotNoChar = words[4],
            LotNoNum = (uint)(words[5] | (words[6] << 16)), // Little Endian
            JudgeFlag1 = words[7],
            JudgeFlag2 = words[8],
            JudgeFlag3 = words[9]
         };
      }

      /// <summary>
      /// 設定 OK/NG/PD 判斷結果（僅修改 JudgeFlag2 的 Bit 15-14，保留其他位元）
      /// </summary>
      /// <param name="result">判斷結果</param>
      public void SetJudgmentResult(JudgmentResult result)
      {
         // 清除 Bit 15-14，保留其他位元 (AND with 0x3FFF = 0011 1111 1111 1111)
         ushort clearedFlag = (ushort)(JudgeFlag2 & 0x3FFF);

         // 設定新的 Bit 15-14
         JudgeFlag2 = (ushort)(clearedFlag | ((int)result << 14));
      }

      /// <summary>
      /// 設定最後一片旗標（僅修改 JudgeFlag2 的 Bit 13，保留其他位元）
      /// </summary>
      /// <param name="isLast">是否為最後一片</param>
      public void SetLastFlag(bool isLast)
      {
         if (isLast)
         {
            // 設定 Bit 13 = 1 (OR with 0x2000)
            JudgeFlag2 |= 1 << 13;
         }
         else
         {
            // 清除 Bit 13 = 0 (AND with ~0x2000)
            JudgeFlag2 &= unchecked((ushort)~(1 << 13));
         }
      }

      #endregion
   }
}
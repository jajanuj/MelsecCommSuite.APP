using System;
using System.Collections.Generic;

namespace MelsecHelper.APP.Services
{
   /// <summary>
   /// 模擬 MX Component 資料讀取器
   /// </summary>
   public class MockMxComponentReader
   {
      private readonly Random _random = new Random();

      /// <summary>
      /// 模擬讀取 8 爐資料 (520 words)
      /// </summary>
      public short[] GetAllOvenData()
      {
         var allData = new List<short>();

         for (int i = 0; i < 8; i++)
         {
            // 每爐 65 words
            var ovenData = new short[65];

            // 1. 配方 No (Word 0)
            ovenData[0] = (short)(100 + i);

            // 2. 爐狀態 (Word 1) - 模擬與 Bit 相關的狀態
            // Bit 0: 運轉中, Bit 1: 異常
            ovenData[1] = (short)(_random.Next(0, 2) == 0 ? 1 : 0);

            // 3. 連線狀態 (Word 2)
            // 1: Remote, 2: Local, 3: Offline
            ovenData[2] = (short)_random.Next(1, 4);

            // 4. 入料相關狀態 (Word 3-5)
            ovenData[3] = (short)_random.Next(0, 8); // 交換狀態
            ovenData[4] = (short)_random.Next(0, 8); // 爐門狀態
            ovenData[5] = (short)_random.Next(0, 4); // 爐門相關

            // 5. 時間年月日 (Word 6-11)
            var now = DateTime.Now;
            ovenData[6] = (short)now.Year;
            ovenData[7] = (short)now.Month;
            ovenData[8] = (short)now.Day;
            ovenData[9] = (short)now.Hour;
            ovenData[10] = (short)now.Minute;
            ovenData[11] = (short)now.Second;

            // 6. 溫度 PV/SV (Word 12-14)
            float tempSv = 200.0f + i * 10;
            float tempPv = tempSv + _random.Next(-5, 5);
            SetDataFloat(ovenData, 13, tempSv); // SV (13-14)
            SetDataFloat(ovenData, 11, tempPv); // PV (11-12)

            // 7. Step 相關 (15-18)
            ovenData[15] = (short)_random.Next(1, 10); // Step No
            ovenData[16] = (short)_random.Next(0, 100); // Hour
            ovenData[17] = (short)_random.Next(0, 60); // Min
            ovenData[18] = (short)now.Second; // Sec (Updated by User Request)

            // 8. 電壓 (19-21 in my plan? No.20-22 => index 19-24, 2 words each)
            SetDataFloat(ovenData, 19, 220.0f + _random.Next(-10, 10)); // Voltage R
            SetDataFloat(ovenData, 21, 220.0f + _random.Next(-10, 10)); // Voltage S
            SetDataFloat(ovenData, 23, 220.0f + _random.Next(-10, 10)); // Voltage T

            // 9. 電流 (22-25) -> index 25-30?
            SetDataFloat(ovenData, 25, 15.0f + (float)_random.NextDouble()); // Current R
            SetDataFloat(ovenData, 27, 16.0f + (float)_random.NextDouble()); // Current S
            SetDataFloat(ovenData, 29, 15.5f + (float)_random.NextDouble()); // Current T

            // 10. 溫度監控 (Temp Monitor 1~6)
            for (int k = 0; k < 6; k++)
            {
               SetDataFloat(ovenData, 31 + k * 2, 180.0f + k * 2);
            }

            // ... 其他依照原計畫填入 ...

            // 11. Recipe Name (Word 47-56)
            string recipeName = $"RCP-TEST-{i:00}";
            byte[] strBytes = System.Text.Encoding.ASCII.GetBytes(recipeName);
            for (int k = 0; k < 10; k++)
            {
               if (k * 2 < strBytes.Length)
               {
                  byte low = strBytes[k * 2];
                  byte high = (k * 2 + 1 < strBytes.Length) ? strBytes[k * 2 + 1] : (byte)0;
                  ovenData[46 + k] = (short)(low | (high << 8));
               }
            }

            // Word 57-65 (Index 56-64) 預設為 0，無需設置

            // 填入列表
            allData.AddRange(ovenData);
         }

         return allData.ToArray();
      }

      private void SetDataFloat(short[] data, int startIndex, float value)
      {
         if (startIndex + 1 >= data.Length) return;
         byte[] bytes = BitConverter.GetBytes(value);
         // 假設低位在前 [Low][High]
         data[startIndex] = BitConverter.ToInt16(bytes, 0);
         data[startIndex + 1] = BitConverter.ToInt16(bytes, 2);
      }
   }
}

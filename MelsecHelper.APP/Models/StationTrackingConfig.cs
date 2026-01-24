using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;

namespace MelsecHelper.APP.Models
{
   /// <summary>
   /// 站別追蹤配置管理
   /// </summary>
   [Serializable]
   public class StationTrackingConfig
   {
      #region Properties

      /// <summary>
      /// 所有站別配置
      /// </summary>
      public List<StationConfig> Stations { get; set; } = new List<StationConfig>();

      #endregion

      #region Public Methods

      /// <summary>
      /// 根據站號取得配置
      /// </summary>
      /// <param name="stationId">站號 (1-22)</param>
      /// <returns>站別配置，若不存在則返回 null</returns>
      public StationConfig GetStation(int stationId)
      {
         return Stations.FirstOrDefault(s => s.StationId == stationId);
      }

      /// <summary>
      /// 驗證配置的完整性
      /// </summary>
      /// <returns>驗證結果訊息，若無問題則返回空字串</returns>
      public string Validate()
      {
         var errors = new List<string>();

         // 檢查是否有重複的站號
         var duplicateIds = Stations.GroupBy(s => s.StationId)
            .Where(g => g.Count() > 1)
            .Select(g => g.Key);
         if (duplicateIds.Any())
         {
            errors.Add($"發現重複的站號: {string.Join(", ", duplicateIds)}");
         }

         // 檢查 Address 是否重疊
         for (int i = 0; i < Stations.Count; i++)
         {
            for (int j = i + 1; j < Stations.Count; j++)
            {
               if (IsAddressOverlap(Stations[i], Stations[j]))
               {
                  errors.Add($"站別 {Stations[i].StationId} 和 {Stations[j].StationId} 的 Address 範圍重疊");
               }
            }
         }

         return errors.Any() ? string.Join("\n", errors) : string.Empty;
      }

      /// <summary>
      /// 從 JSON 檔案載入配置
      /// </summary>
      /// <param name="filePath">檔案路徑</param>
      /// <returns>載入的配置物件</returns>
      public static StationTrackingConfig LoadFromFile(string filePath)
      {
         if (!File.Exists(filePath))
         {
            throw new FileNotFoundException($"配置檔案不存在: {filePath}");
         }

         try
         {
            string json = File.ReadAllText(filePath, Encoding.UTF8);
            var serializer = new JavaScriptSerializer();
            var config = serializer.Deserialize<StationTrackingConfig>(json);

            // 驗證配置
            string validationError = config.Validate();
            if (!string.IsNullOrEmpty(validationError))
            {
               throw new InvalidOperationException($"配置檔案驗證失敗:\n{validationError}");
            }

            return config;
         }
         catch (Exception ex)
         {
            throw new InvalidOperationException($"載入配置檔案失敗: {ex.Message}", ex);
         }
      }

      /// <summary>
      /// 儲存配置到 JSON 檔案
      /// </summary>
      /// <param name="filePath">檔案路徑</param>
      public void SaveToFile(string filePath)
      {
         try
         {
            // 確保目錄存在
            string directory = Path.GetDirectoryName(filePath);
            if (!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
            {
               Directory.CreateDirectory(directory);
            }

            var serializer = new JavaScriptSerializer();
            string json = serializer.Serialize(this);

            // 格式化 JSON (簡易版)
            json = FormatJson(json);

            File.WriteAllText(filePath, json, Encoding.UTF8);
         }
         catch (Exception ex)
         {
            throw new InvalidOperationException($"儲存配置檔案失敗: {ex.Message}", ex);
         }
      }

      #endregion

      #region Private Methods

      /// <summary>
      /// 檢查兩個站別的 Address 範圍是否重疊
      /// </summary>
      private bool IsAddressOverlap(StationConfig station1, StationConfig station2)
      {
         // 解析起始 Address
         int start1 = ParseAddress(station1.StartAddress);
         int end1 = start1 + station1.GetTotalDataLength();

         int start2 = ParseAddress(station2.StartAddress);
         int end2 = start2 + station2.GetTotalDataLength();

         // 檢查是否重疊
         return !(end1 <= start2 || end2 <= start1);
      }

      /// <summary>
      /// 解析 Address 字串為整數
      /// </summary>
      private int ParseAddress(string address)
      {
         string hexPart = address.Substring(2); // 移除 "LW" 前綴
         return Convert.ToInt32(hexPart, 16);
      }

      /// <summary>
      /// 簡易 JSON 格式化
      /// </summary>
      private string FormatJson(string json)
      {
         var sb = new StringBuilder();
         int indent = 0;
         bool inString = false;

         for (int i = 0; i < json.Length; i++)
         {
            char c = json[i];

            if (c == '"' && (i == 0 || json[i - 1] != '\\'))
            {
               inString = !inString;
            }

            if (!inString)
            {
               if (c == '{' || c == '[')
               {
                  sb.Append(c);
                  sb.AppendLine();
                  indent++;
                  sb.Append(new string(' ', indent * 2));
               }
               else if (c == '}' || c == ']')
               {
                  sb.AppendLine();
                  indent--;
                  sb.Append(new string(' ', indent * 2));
                  sb.Append(c);
               }
               else if (c == ',')
               {
                  sb.Append(c);
                  sb.AppendLine();
                  sb.Append(new string(' ', indent * 2));
               }
               else if (c == ':')
               {
                  sb.Append(c);
                  sb.Append(' ');
               }
               else if (!char.IsWhiteSpace(c))
               {
                  sb.Append(c);
               }
            }
            else
            {
               sb.Append(c);
            }
         }

         return sb.ToString();
      }

      #endregion
   }
}
using System;

namespace MelsecHelper.APP.Models
{
   /// <summary>
   /// 定期報告功能設定。
   /// </summary>
   [Serializable]
   public class RegularReportSettings
   {
      #region Properties

      /// <summary>
      /// 定期報告間隔毫秒。
      /// </summary>
      public int Interval { get; set; } = 30000;

      #endregion
   }
}
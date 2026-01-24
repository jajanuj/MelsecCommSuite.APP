using System;

namespace MelsecHelper.APP.Models
{
   /// <summary>
   /// 對時功能設定。
   /// </summary>
   [Serializable]
   public class MoveOutSettings
   {
      #region Properties

      /// <summary>
      /// T1逾時毫秒數
      /// </summary>
      public int T1Timeout { get; set; } = 1000;

      /// <summary>
      /// T2逾時毫秒數
      /// </summary>
      public int T2Timeout { get; set; } = 1000;

      #endregion
   }
}
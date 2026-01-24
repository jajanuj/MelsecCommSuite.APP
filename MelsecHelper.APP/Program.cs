using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MelsecHelper.APP
{
   internal static class Program
   {
      #region Private Methods

      /// <summary>
      /// 應用程式的主要進入點。
      /// </summary>
      [STAThread]
      static void Main()
      {
         Application.EnableVisualStyles();
         Application.SetCompatibleTextRenderingDefault(false);
         Application.Run(new Form1());
      }

      #endregion
   }
}
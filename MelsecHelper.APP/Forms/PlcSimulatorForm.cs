using System;
using System.Windows.Forms;
using Melsec.Helper.Models;
using MelsecHelper.APP.Services;

namespace MelsecHelper.APP.Forms
{
   public partial class PlcSimulatorForm : Form
   {
      #region Constant

      private const string AddrHeartbeatRequestFlag = "LB0100";
      private const string AddrHeartbeatResponseFlag = "LB0300";

      #endregion

      #region Fields

      private readonly PlcSimulator _plcSimulator;

      #endregion

      #region Constructors

      public PlcSimulatorForm()
      {
      }

      public PlcSimulatorForm(PlcSimulator plcSimulator)
      {
         _plcSimulator = plcSimulator;
         InitializeComponent();
      }

      #endregion

      #region Private Methods

      private void btnStartHeartbeat_Click(object sender, EventArgs e)
      {
         var requestFlag = new LinkDeviceAddress("LB", CCLinkConstants.HeartbeatRequestFlagAddress, 1);
         var responseFlag = new LinkDeviceAddress("LB", CCLinkConstants.HeartbeatResponseFlagAddress, 1);
         _plcSimulator.StartPulse(requestFlag, responseFlag, TimeSpan.FromSeconds(3), 1000);
      }

      private void btnStopHeartbeat_Click(object sender, EventArgs e)
      {
         _plcSimulator.Stop();
      }

      private void chkHeartbeatT1Timeout_CheckedChanged(object sender, EventArgs e)
      {
         _plcSimulator.HeartbeatT1Timeout = chkHeartbeatT1Timeout.Checked;
      }

      #endregion
   }
}
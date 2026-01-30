using Melsec.Helper.Forms;
using MelsecHelper.APP.Models;
using System;

namespace MelsecHelper.APP.Forms
{
   public partial class MelsecBoardSettingForm : SettingsForm
   {
      #region Constructors

      public MelsecBoardSettingForm(AppControllerSettings settings) : base(settings)
      {
         InitializeComponent();
      }

      #endregion

      #region Protected Methods

      protected override void LoadToUI()
      {
         base.LoadToUI();

         if (Settings is AppControllerSettings appSettings)
         {
            // Board Parameters
            numPort.Value = appSettings.Channel;
            numNetwork.Value = appSettings.NetworkNo;
            numStation.Value = appSettings.StationNo;
            numTimeout.Value = appSettings.TimeoutMs;
            numRetryCount.Value = appSettings.RetryCount;
            numRetryBackoff.Value = appSettings.RetryBackoffMs;
            cmbEndian.SelectedItem = appSettings.Endian ?? "Big";
            chkIsx64.Checked = appSettings.Isx64;

            // App Parameters
            numTimeSync.Value = appSettings.TimeSyncIntervalMs;
            txtTrigger.Text = appSettings.TimeSync?.TriggerAddress ?? "LB0301";
            txtData.Text = appSettings.TimeSync?.DataBaseAddress ?? "LW0000";
            paramHeartbeatRequestAddress.TextValue = appSettings.Heartbeat?.RequestAddress ?? "LB0100";
            paramHeartbeatResponseAddress.TextValue = appSettings.Heartbeat?.ResponseAddress ?? "LB0300";
            paramHeartbeatInterval.Value = appSettings.Heartbeat?.HeartbeatIntervalMs ?? 300;

            // Tracking Parameters
            txtLoadingRobotAddr.Text = appSettings.Tracking?.LoadingRobotAddress ?? "LW0000";
            txtLoadingStationAddr.Text = appSettings.Tracking?.LoadingStationAddress ?? "LW0010";
            txtUnloadingRobotAddr.Text = appSettings.Tracking?.UnloadingRobotAddress ?? "LW0020";
            txtUnloadingStationAddr.Text = appSettings.Tracking?.UnloadingStationAddress ?? "LW0030";

            // Maintenance Timeout Parameters
            paramMplcToEqT1Timeout.Value = appSettings.Maintenance?.PlcToDeviceT1Timeout ?? 1000;
            paramMplcToEqT2Timeout.Value = appSettings.Maintenance?.PlcToDeviceT2Timeout ?? 1000;
            paramEqToMplcT1Timeout.Value = appSettings.Maintenance?.DeviceToPlcT1Timeout ?? 1000;
            paramEqToMplcT2Timeout.Value = appSettings.Maintenance?.DeviceToPlcT2Timeout ?? 1000;

            // Maintenance Address Parameters
            paramAddrPositionDataBase.TextValue = appSettings.Maintenance?.AddrPositionDataBase ?? "LW184A";
            paramAddrPlcToDeviceRequestFlag.TextValue = appSettings.Maintenance?.AddrPlcToDeviceRequestFlag ?? "LB0106";
            paramAddrPlcToDeviceRequestTrackingData.TextValue = appSettings.Maintenance?.AddrPlcToDeviceRequestTrackingData ?? "LW05BE";
            paramAddrPlcToDeviceRequestPosData.TextValue = appSettings.Maintenance?.AddrPlcToDeviceRequestPosData ?? "LW05C8";
            paramAddrPlcToDeviceResponseOk.TextValue = appSettings.Maintenance?.AddrPlcToDeviceResponseOk ?? "LB0304";
            paramAddrPlcToDeviceResponseNg.TextValue = appSettings.Maintenance?.AddrPlcToDeviceResponseNg ?? "LB0305";
            paramAddrDeviceToPlcRequestFlag.TextValue = appSettings.Maintenance?.AddrDeviceToPlcRequestFlag ?? "LB0306";
            paramAddrDeviceToPlcRequestTrackingData.TextValue = appSettings.Maintenance?.AddrDeviceToPlcRequestTrackingData ?? "LW17D1";
            paramAddrDeviceToPlcRequestPosData.TextValue = appSettings.Maintenance?.AddrDeviceToPlcRequestPosData ?? "LW17DB";
            paramAddrDeviceToPlcResponseFlag.TextValue = appSettings.Maintenance?.AddrDeviceToPlcResponseFlag ?? "LB0107";

            paramMoveOutT1Timeout.Value = appSettings.MoveOut?.T1Timeout ?? 1000;
            paramMoveOutT2Timeout.Value = appSettings.MoveOut?.T2Timeout ?? 1000;

            paramRegularReportInterval.Value = appSettings.RegularReport?.Interval ?? 30000;

            paramRecipeRequestFlagAddress.TextValue = appSettings.RecipeCheck.RequestFlagAddress ?? "LB0303";
            paramRecipeRequestDataAddress.TextValue = appSettings.RecipeCheck.RequestDataAddress ?? "LW17C7";
            paramRecipeRequestRecipeNoAddress.TextValue = appSettings.RecipeCheck.RequestRecipeNoAddress ?? "LW1155";
            paramRecipeResponseOkAddress.TextValue = appSettings.RecipeCheck.ResponseOkAddress ?? "LB0104";
            paramRecipeResponseNgAddress.TextValue = appSettings.RecipeCheck.ResponseNgAddress ?? "LB0105";
            paramRecipeResponseThicknessAddress.TextValue = appSettings.RecipeCheck.ResponseThicknessAddress ?? "LW05DA";
            paramRecipeResponseRecipeNoAddress.TextValue = appSettings.RecipeCheck.ResponseRecipeNoAddress ?? "LW05DC";
            paramRecipeT1Timeout.Value = appSettings.RecipeCheck?.ResponseT1Timeout ?? 5000;
         }
      }

      protected override void btnSave_Click(object sender, EventArgs e)
      {
         base.btnSave_Click(sender, e);

         if (Settings is AppControllerSettings appSettings)
         {
            // Board Parameters
            appSettings.Channel = (int)numPort.Value;
            appSettings.NetworkNo = (int)numNetwork.Value;
            appSettings.StationNo = (int)numStation.Value;
            appSettings.TimeoutMs = (int)numTimeout.Value;
            appSettings.RetryCount = (int)numRetryCount.Value;
            appSettings.RetryBackoffMs = (int)numRetryBackoff.Value;
            appSettings.Endian = cmbEndian.SelectedItem?.ToString() ?? "Big";
            appSettings.Isx64 = chkIsx64.Checked;
            appSettings.DriverType = MelsecDriverType.MelsecBoard; // Ensure driver type is set

            // App Parameters
            appSettings.Heartbeat.RequestAddress = paramHeartbeatRequestAddress.TextValue;
            appSettings.Heartbeat.ResponseAddress = paramHeartbeatResponseAddress.TextValue;
            appSettings.Heartbeat.HeartbeatIntervalMs = (int)paramHeartbeatInterval.Value;
            appSettings.TimeSyncIntervalMs = (int)numTimeSync.Value;
            appSettings.TimeSync.TriggerAddress = txtTrigger.Text?.Trim() ?? "LB0301";
            appSettings.TimeSync.DataBaseAddress = txtData.Text?.Trim() ?? "LW0000";

            // Tracking Parameters
            appSettings.Tracking.LoadingRobotAddress = txtLoadingRobotAddr.Text?.Trim() ?? "LW0000";
            appSettings.Tracking.LoadingStationAddress = txtLoadingStationAddr.Text?.Trim() ?? "LW0010";
            appSettings.Tracking.UnloadingRobotAddress = txtUnloadingRobotAddr.Text?.Trim() ?? "LW0020";
            appSettings.Tracking.UnloadingStationAddress = txtUnloadingStationAddr.Text?.Trim() ?? "LW0030";

            // Maintenance Timeout Parameters
            appSettings.Maintenance.PlcToDeviceT1Timeout = (int)paramMplcToEqT1Timeout.Value;
            appSettings.Maintenance.PlcToDeviceT2Timeout = (int)paramMplcToEqT2Timeout.Value;
            appSettings.Maintenance.DeviceToPlcT1Timeout = (int)paramEqToMplcT1Timeout.Value;
            appSettings.Maintenance.DeviceToPlcT2Timeout = (int)paramEqToMplcT2Timeout.Value;

            // Maintenance Address Parameters
            appSettings.Maintenance.AddrPositionDataBase = paramAddrPositionDataBase.TextValue?.Trim() ?? "LW184A";
            appSettings.Maintenance.AddrPlcToDeviceRequestFlag = paramAddrPlcToDeviceRequestFlag.TextValue?.Trim() ?? "LB0106";
            appSettings.Maintenance.AddrPlcToDeviceRequestTrackingData = paramAddrPlcToDeviceRequestTrackingData.TextValue?.Trim() ?? "LW05BE";
            appSettings.Maintenance.AddrPlcToDeviceRequestPosData = paramAddrPlcToDeviceRequestPosData.TextValue?.Trim() ?? "LW05C8";
            appSettings.Maintenance.AddrPlcToDeviceResponseOk = paramAddrPlcToDeviceResponseOk.TextValue?.Trim() ?? "LB0304";
            appSettings.Maintenance.AddrPlcToDeviceResponseNg = paramAddrPlcToDeviceResponseNg.TextValue?.Trim() ?? "LB0305";
            appSettings.Maintenance.AddrDeviceToPlcRequestFlag = paramAddrDeviceToPlcRequestFlag.TextValue?.Trim() ?? "LB0306";
            appSettings.Maintenance.AddrDeviceToPlcRequestTrackingData = paramAddrDeviceToPlcRequestTrackingData.TextValue?.Trim() ?? "LW17D1";
            appSettings.Maintenance.AddrDeviceToPlcRequestPosData = paramAddrDeviceToPlcRequestPosData.TextValue?.Trim() ?? "LW17DB";
            appSettings.Maintenance.AddrDeviceToPlcResponseFlag = paramAddrDeviceToPlcResponseFlag.TextValue?.Trim() ?? "LB0107";

            appSettings.MoveOut.T1Timeout = (int)paramMoveOutT1Timeout.Value;
            appSettings.MoveOut.T2Timeout = (int)paramMoveOutT2Timeout.Value;

            appSettings.RegularReport.Interval = (int)paramRegularReportInterval.Value;
         }
      }

      #endregion
   }
}
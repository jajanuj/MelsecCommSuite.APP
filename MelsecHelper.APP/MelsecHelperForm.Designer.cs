namespace MelsecHelper.APP
{
   partial class Form1
   {
      /// <summary>
      /// 設計工具所需的變數。
      /// </summary>
      private System.ComponentModel.IContainer components = null;



      /// <summary>
      /// 清除任何使用中的資源。
      /// </summary>
      /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form 設計工具產生的程式碼

      /// <summary>
      /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
      /// 這個方法的內容。
      /// </summary>
      private void InitializeComponent()
      {
         this.components = new System.ComponentModel.Container();
         this.grpConnectionMode = new System.Windows.Forms.GroupBox();
         this.cmbDriverType = new System.Windows.Forms.ComboBox();
         this.btnOpen = new System.Windows.Forms.Button();
         this.btnClose = new System.Windows.Forms.Button();
         this.btnStartTimeSync = new System.Windows.Forms.Button();
         this.btnStopTimeSync = new System.Windows.Forms.Button();
         this.btnForceTimeSync = new System.Windows.Forms.Button();
         this.btnStartHeartbeat = new System.Windows.Forms.Button();
         this.btnStopHeartbeat = new System.Windows.Forms.Button();
         this.btnStopSimulator = new System.Windows.Forms.Button();
         this.btnPlcSettings = new System.Windows.Forms.Button();
         this.btnScanMonitor = new System.Windows.Forms.Button();
         this.btnTrackingControl = new System.Windows.Forms.Button();
         this.btnStartCommonReporting = new System.Windows.Forms.Button();
         this.btnSetCommonReporting = new System.Windows.Forms.Button();
         this.btnStartLinkReport = new System.Windows.Forms.Button();
         this.btnStopLinkReport = new System.Windows.Forms.Button();
         this.btnSendLinkData = new System.Windows.Forms.Button();
         this.grpManualTime = new System.Windows.Forms.GroupBox();
         this.dtpDate = new System.Windows.Forms.DateTimePicker();
         this.dtpTime = new System.Windows.Forms.DateTimePicker();
         this.btnSyncFromPc = new System.Windows.Forms.Button();
         this.btnSetTimeToPlc = new System.Windows.Forms.Button();
         this.grpConnectMode = new System.Windows.Forms.GroupBox();
         this.rbtnOffline = new System.Windows.Forms.RadioButton();
         this.rbtnOnline = new System.Windows.Forms.RadioButton();
         this.btnStartMaintMonitor = new System.Windows.Forms.Button();
         this.btnStopMaintMonitor = new System.Windows.Forms.Button();
         this.lstLog = new System.Windows.Forms.ListBox();
         this.lblStatus = new System.Windows.Forms.Label();
         this.grpAlarm = new System.Windows.Forms.GroupBox();
         this.btnDeleteAlarm = new System.Windows.Forms.Button();
         this.btnAlarmReset = new System.Windows.Forms.Button();
         this.txtAlarmCode = new System.Windows.Forms.TextBox();
         this.btnAddAlarm = new System.Windows.Forms.Button();
         this.btnRecipeCheck = new System.Windows.Forms.Button();
         this.textBox1 = new System.Windows.Forms.TextBox();
         this.btnHandshake = new System.Windows.Forms.Button();
         this.btnManualRun = new System.Windows.Forms.Button();
         this.btnAutoRun = new System.Windows.Forms.Button();
         this.ltbErrorCodes = new System.Windows.Forms.ListBox();
         this.tmrScan = new System.Windows.Forms.Timer(this.components);
         this.btnShowPlcSimulatorForm = new System.Windows.Forms.Button();
         this.btnLotMixingPrevention = new System.Windows.Forms.Button();
         this.btnShowPosTrackingDataForm = new System.Windows.Forms.Button();
         this.tabMain = new System.Windows.Forms.TabControl();
         this.tpBasic = new System.Windows.Forms.TabPage();
         this.tpCheckClock = new System.Windows.Forms.TabPage();
         this.tpClockUpdate = new System.Windows.Forms.TabPage();
         this.tpMoveOut = new System.Windows.Forms.TabPage();
         this.tpRecipeCheck = new System.Windows.Forms.TabPage();
         this.tpAlarm = new System.Windows.Forms.TabPage();
         this.tpCommonReport = new System.Windows.Forms.TabPage();
         this.tpMaintenance = new System.Windows.Forms.TabPage();
         this.tpTrackingData = new System.Windows.Forms.TabPage();
         this.tpPosReport = new System.Windows.Forms.TabPage();
         this.tpLotMixingPrevention = new System.Windows.Forms.TabPage();
         this.tpLinkReport = new System.Windows.Forms.TabPage();
         this.tpHandshake = new System.Windows.Forms.TabPage();
         this.grpConnectionMode.SuspendLayout();
         this.grpManualTime.SuspendLayout();
         this.grpConnectMode.SuspendLayout();
         this.grpAlarm.SuspendLayout();
         this.tabMain.SuspendLayout();
         this.tpBasic.SuspendLayout();
         this.tpCheckClock.SuspendLayout();
         this.tpClockUpdate.SuspendLayout();
         this.tpRecipeCheck.SuspendLayout();
         this.tpAlarm.SuspendLayout();
         this.tpCommonReport.SuspendLayout();
         this.tpMaintenance.SuspendLayout();
         this.tpTrackingData.SuspendLayout();
         this.tpPosReport.SuspendLayout();
         this.tpLotMixingPrevention.SuspendLayout();
         this.tpLinkReport.SuspendLayout();
         this.tpHandshake.SuspendLayout();
         this.SuspendLayout();
         // 
         // grpConnectionMode
         // 
         this.grpConnectionMode.Controls.Add(this.cmbDriverType);
         this.grpConnectionMode.Location = new System.Drawing.Point(13, 13);
         this.grpConnectionMode.Margin = new System.Windows.Forms.Padding(10);
         this.grpConnectionMode.Name = "grpConnectionMode";
         this.grpConnectionMode.Size = new System.Drawing.Size(200, 80);
         this.grpConnectionMode.TabIndex = 15;
         this.grpConnectionMode.TabStop = false;
         this.grpConnectionMode.Text = "Driver Type";
         // 
         // cmbDriverType
         // 
         this.cmbDriverType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cmbDriverType.FormattingEnabled = true;
         this.cmbDriverType.Location = new System.Drawing.Point(15, 30);
         this.cmbDriverType.Name = "cmbDriverType";
         this.cmbDriverType.Size = new System.Drawing.Size(170, 23);
         this.cmbDriverType.TabIndex = 0;
         this.cmbDriverType.SelectedIndexChanged += new System.EventHandler(this.cmbDriverType_SelectedIndexChanged);
         // 
         // btnOpen
         // 
         this.btnOpen.AutoSize = true;
         this.btnOpen.Location = new System.Drawing.Point(28, 113);
         this.btnOpen.Margin = new System.Windows.Forms.Padding(10);
         this.btnOpen.Name = "btnOpen";
         this.btnOpen.Size = new System.Drawing.Size(75, 26);
         this.btnOpen.TabIndex = 0;
         this.btnOpen.Text = "Open";
         this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
         // 
         // btnClose
         // 
         this.btnClose.AutoSize = true;
         this.btnClose.Enabled = false;
         this.btnClose.Location = new System.Drawing.Point(123, 113);
         this.btnClose.Margin = new System.Windows.Forms.Padding(10);
         this.btnClose.Name = "btnClose";
         this.btnClose.Size = new System.Drawing.Size(75, 26);
         this.btnClose.TabIndex = 3;
         this.btnClose.Text = "Close";
         this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
         // 
         // btnStartTimeSync
         // 
         this.btnStartTimeSync.AutoSize = true;
         this.btnStartTimeSync.Location = new System.Drawing.Point(17, 31);
         this.btnStartTimeSync.Margin = new System.Windows.Forms.Padding(10);
         this.btnStartTimeSync.Name = "btnStartTimeSync";
         this.btnStartTimeSync.Size = new System.Drawing.Size(115, 26);
         this.btnStartTimeSync.TabIndex = 6;
         this.btnStartTimeSync.Text = "Start TimeSync";
         this.btnStartTimeSync.Click += new System.EventHandler(this.btnStartTimeSync_Click);
         // 
         // btnStopTimeSync
         // 
         this.btnStopTimeSync.AutoSize = true;
         this.btnStopTimeSync.Location = new System.Drawing.Point(152, 31);
         this.btnStopTimeSync.Margin = new System.Windows.Forms.Padding(10);
         this.btnStopTimeSync.Name = "btnStopTimeSync";
         this.btnStopTimeSync.Size = new System.Drawing.Size(108, 26);
         this.btnStopTimeSync.TabIndex = 12;
         this.btnStopTimeSync.Text = "Stop TimeSync";
         this.btnStopTimeSync.Click += new System.EventHandler(this.btnStopTimeSync_Click);
         // 
         // btnForceTimeSync
         // 
         this.btnForceTimeSync.Location = new System.Drawing.Point(17, 189);
         this.btnForceTimeSync.Margin = new System.Windows.Forms.Padding(10);
         this.btnForceTimeSync.Name = "btnForceTimeSync";
         this.btnForceTimeSync.Size = new System.Drawing.Size(137, 23);
         this.btnForceTimeSync.TabIndex = 13;
         this.btnForceTimeSync.Text = "Force Time Sync";
         this.btnForceTimeSync.Click += new System.EventHandler(this.btnForceTimeSync_Click);
         // 
         // btnStartHeartbeat
         // 
         this.btnStartHeartbeat.Location = new System.Drawing.Point(27, 27);
         this.btnStartHeartbeat.Margin = new System.Windows.Forms.Padding(10);
         this.btnStartHeartbeat.Name = "btnStartHeartbeat";
         this.btnStartHeartbeat.Size = new System.Drawing.Size(132, 26);
         this.btnStartHeartbeat.TabIndex = 8;
         this.btnStartHeartbeat.Text = "Start Heartbeat";
         this.btnStartHeartbeat.UseVisualStyleBackColor = true;
         this.btnStartHeartbeat.Click += new System.EventHandler(this.btnStartHeartbeat_Click);
         // 
         // btnStopHeartbeat
         // 
         this.btnStopHeartbeat.Location = new System.Drawing.Point(188, 27);
         this.btnStopHeartbeat.Margin = new System.Windows.Forms.Padding(10);
         this.btnStopHeartbeat.Name = "btnStopHeartbeat";
         this.btnStopHeartbeat.Size = new System.Drawing.Size(132, 26);
         this.btnStopHeartbeat.TabIndex = 11;
         this.btnStopHeartbeat.Text = "Stop Heartbeat";
         this.btnStopHeartbeat.UseVisualStyleBackColor = true;
         this.btnStopHeartbeat.Click += new System.EventHandler(this.btnStopHeartbeat_Click);
         // 
         // btnStopSimulator
         // 
         this.btnStopSimulator.Enabled = false;
         this.btnStopSimulator.Location = new System.Drawing.Point(482, 173);
         this.btnStopSimulator.Margin = new System.Windows.Forms.Padding(10);
         this.btnStopSimulator.Name = "btnStopSimulator";
         this.btnStopSimulator.Size = new System.Drawing.Size(132, 26);
         this.btnStopSimulator.TabIndex = 9;
         this.btnStopSimulator.Text = "Stop Simulator";
         this.btnStopSimulator.UseVisualStyleBackColor = true;
         this.btnStopSimulator.Click += new System.EventHandler(this.btnStopSimulator_Click);
         // 
         // btnPlcSettings
         // 
         this.btnPlcSettings.Location = new System.Drawing.Point(245, 149);
         this.btnPlcSettings.Margin = new System.Windows.Forms.Padding(10);
         this.btnPlcSettings.Name = "btnPlcSettings";
         this.btnPlcSettings.Size = new System.Drawing.Size(132, 26);
         this.btnPlcSettings.TabIndex = 10;
         this.btnPlcSettings.Text = "Show Settings";
         this.btnPlcSettings.UseVisualStyleBackColor = true;
         this.btnPlcSettings.Click += new System.EventHandler(this.btnPlcSettings_Click);
         // 
         // btnScanMonitor
         // 
         this.btnScanMonitor.Location = new System.Drawing.Point(245, 113);
         this.btnScanMonitor.Margin = new System.Windows.Forms.Padding(10);
         this.btnScanMonitor.Name = "btnScanMonitor";
         this.btnScanMonitor.Size = new System.Drawing.Size(132, 26);
         this.btnScanMonitor.TabIndex = 14;
         this.btnScanMonitor.Text = "Scan Monitor";
         this.btnScanMonitor.UseVisualStyleBackColor = true;
         this.btnScanMonitor.Click += new System.EventHandler(this.btnScanMonitor_Click);
         // 
         // btnTrackingControl
         // 
         this.btnTrackingControl.Location = new System.Drawing.Point(218, 64);
         this.btnTrackingControl.Margin = new System.Windows.Forms.Padding(10);
         this.btnTrackingControl.Name = "btnTrackingControl";
         this.btnTrackingControl.Size = new System.Drawing.Size(181, 26);
         this.btnTrackingControl.TabIndex = 18;
         this.btnTrackingControl.Text = "追蹤資料管理";
         this.btnTrackingControl.UseVisualStyleBackColor = true;
         this.btnTrackingControl.Click += new System.EventHandler(this.btnTrackingControl_Click);
         // 
         // btnStartCommonReporting
         // 
         this.btnStartCommonReporting.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
         this.btnStartCommonReporting.Location = new System.Drawing.Point(75, 100);
         this.btnStartCommonReporting.Margin = new System.Windows.Forms.Padding(10);
         this.btnStartCommonReporting.Name = "btnStartCommonReporting";
         this.btnStartCommonReporting.Size = new System.Drawing.Size(181, 26);
         this.btnStartCommonReporting.TabIndex = 17;
         this.btnStartCommonReporting.Text = "Start Common Reporting";
         this.btnStartCommonReporting.UseVisualStyleBackColor = true;
         this.btnStartCommonReporting.Click += new System.EventHandler(this.btnStartCommonReporting_Click);
         // 
         // btnSetCommonReporting
         // 
         this.btnSetCommonReporting.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
         this.btnSetCommonReporting.Location = new System.Drawing.Point(325, 100);
         this.btnSetCommonReporting.Margin = new System.Windows.Forms.Padding(10);
         this.btnSetCommonReporting.Name = "btnSetCommonReporting";
         this.btnSetCommonReporting.Size = new System.Drawing.Size(181, 26);
         this.btnSetCommonReporting.TabIndex = 16;
         this.btnSetCommonReporting.Text = "Set Common Reporting";
         this.btnSetCommonReporting.UseVisualStyleBackColor = true;
         this.btnSetCommonReporting.Click += new System.EventHandler(this.btnSetCommonReporting_Click);
         // 
         // btnStartLinkReport
         // 
         this.btnStartLinkReport.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
         this.btnStartLinkReport.Location = new System.Drawing.Point(61, 55);
         this.btnStartLinkReport.Margin = new System.Windows.Forms.Padding(10);
         this.btnStartLinkReport.Name = "btnStartLinkReport";
         this.btnStartLinkReport.Size = new System.Drawing.Size(181, 26);
         this.btnStartLinkReport.TabIndex = 19;
         this.btnStartLinkReport.Text = "Start Link Report";
         this.btnStartLinkReport.UseVisualStyleBackColor = true;
         this.btnStartLinkReport.Click += new System.EventHandler(this.btnStartLinkReport_Click);
         // 
         // btnStopLinkReport
         // 
         this.btnStopLinkReport.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
         this.btnStopLinkReport.Location = new System.Drawing.Point(286, 55);
         this.btnStopLinkReport.Margin = new System.Windows.Forms.Padding(10);
         this.btnStopLinkReport.Name = "btnStopLinkReport";
         this.btnStopLinkReport.Size = new System.Drawing.Size(181, 26);
         this.btnStopLinkReport.TabIndex = 20;
         this.btnStopLinkReport.Text = "Stop Link Report";
         this.btnStopLinkReport.UseVisualStyleBackColor = true;
         this.btnStopLinkReport.Click += new System.EventHandler(this.btnStopLinkReport_Click);
         // 
         // btnSendLinkData
         // 
         this.btnSendLinkData.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
         this.btnSendLinkData.Location = new System.Drawing.Point(76, 101);
         this.btnSendLinkData.Margin = new System.Windows.Forms.Padding(10);
         this.btnSendLinkData.Name = "btnSendLinkData";
         this.btnSendLinkData.Size = new System.Drawing.Size(181, 26);
         this.btnSendLinkData.TabIndex = 21;
         this.btnSendLinkData.Text = "Send Link Data";
         this.btnSendLinkData.UseVisualStyleBackColor = true;
         this.btnSendLinkData.Click += new System.EventHandler(this.btnSendLinkData_Click);
         // 
         // grpManualTime
         // 
         this.grpManualTime.Controls.Add(this.dtpDate);
         this.grpManualTime.Controls.Add(this.dtpTime);
         this.grpManualTime.Controls.Add(this.btnSyncFromPc);
         this.grpManualTime.Controls.Add(this.btnSetTimeToPlc);
         this.grpManualTime.Location = new System.Drawing.Point(17, 94);
         this.grpManualTime.Margin = new System.Windows.Forms.Padding(10);
         this.grpManualTime.Name = "grpManualTime";
         this.grpManualTime.Size = new System.Drawing.Size(300, 80);
         this.grpManualTime.TabIndex = 11;
         this.grpManualTime.TabStop = false;
         this.grpManualTime.Text = "手動設定時間";
         // 
         // dtpDate
         // 
         this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
         this.dtpDate.Location = new System.Drawing.Point(6, 21);
         this.dtpDate.Name = "dtpDate";
         this.dtpDate.Size = new System.Drawing.Size(116, 22);
         this.dtpDate.TabIndex = 0;
         // 
         // dtpTime
         // 
         this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
         this.dtpTime.Location = new System.Drawing.Point(6, 49);
         this.dtpTime.Name = "dtpTime";
         this.dtpTime.ShowUpDown = true;
         this.dtpTime.Size = new System.Drawing.Size(116, 22);
         this.dtpTime.TabIndex = 1;
         // 
         // btnSyncFromPc
         // 
         this.btnSyncFromPc.Location = new System.Drawing.Point(128, 18);
         this.btnSyncFromPc.Name = "btnSyncFromPc";
         this.btnSyncFromPc.Size = new System.Drawing.Size(150, 25);
         this.btnSyncFromPc.TabIndex = 2;
         this.btnSyncFromPc.Text = "同步電腦時間";
         this.btnSyncFromPc.UseVisualStyleBackColor = true;
         this.btnSyncFromPc.Click += new System.EventHandler(this.btnSyncFromPc_Click);
         // 
         // btnSetTimeToPlc
         // 
         this.btnSetTimeToPlc.Location = new System.Drawing.Point(128, 46);
         this.btnSetTimeToPlc.Name = "btnSetTimeToPlc";
         this.btnSetTimeToPlc.Size = new System.Drawing.Size(150, 25);
         this.btnSetTimeToPlc.TabIndex = 3;
         this.btnSetTimeToPlc.Text = "寫入時間至 PLC";
         this.btnSetTimeToPlc.UseVisualStyleBackColor = true;
         this.btnSetTimeToPlc.Click += new System.EventHandler(this.btnSetTimeToPlc_Click);
         // 
         // grpConnectMode
         // 
         this.grpConnectMode.Controls.Add(this.rbtnOffline);
         this.grpConnectMode.Controls.Add(this.rbtnOnline);
         this.grpConnectMode.Location = new System.Drawing.Point(245, 13);
         this.grpConnectMode.Name = "grpConnectMode";
         this.grpConnectMode.Size = new System.Drawing.Size(112, 87);
         this.grpConnectMode.TabIndex = 23;
         this.grpConnectMode.TabStop = false;
         this.grpConnectMode.Text = "連線模式";
         // 
         // rbtnOffline
         // 
         this.rbtnOffline.AutoSize = true;
         this.rbtnOffline.Checked = true;
         this.rbtnOffline.Location = new System.Drawing.Point(17, 49);
         this.rbtnOffline.Name = "rbtnOffline";
         this.rbtnOffline.Size = new System.Drawing.Size(62, 19);
         this.rbtnOffline.TabIndex = 1;
         this.rbtnOffline.TabStop = true;
         this.rbtnOffline.Text = "Offline";
         this.rbtnOffline.UseVisualStyleBackColor = true;
         this.rbtnOffline.CheckedChanged += new System.EventHandler(this.Offline_CheckedChanged);
         // 
         // rbtnOnline
         // 
         this.rbtnOnline.AutoSize = true;
         this.rbtnOnline.Location = new System.Drawing.Point(17, 25);
         this.rbtnOnline.Name = "rbtnOnline";
         this.rbtnOnline.Size = new System.Drawing.Size(61, 19);
         this.rbtnOnline.TabIndex = 0;
         this.rbtnOnline.Text = "Online";
         this.rbtnOnline.UseVisualStyleBackColor = true;
         this.rbtnOnline.CheckedChanged += new System.EventHandler(this.Online_CheckedChanged);
         // 
         // btnStartMaintMonitor
         // 
         this.btnStartMaintMonitor.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
         this.btnStartMaintMonitor.Location = new System.Drawing.Point(91, 54);
         this.btnStartMaintMonitor.Margin = new System.Windows.Forms.Padding(10);
         this.btnStartMaintMonitor.Name = "btnStartMaintMonitor";
         this.btnStartMaintMonitor.Size = new System.Drawing.Size(186, 26);
         this.btnStartMaintMonitor.TabIndex = 24;
         this.btnStartMaintMonitor.Text = "Start Maint Monitor";
         this.btnStartMaintMonitor.UseVisualStyleBackColor = true;
         this.btnStartMaintMonitor.Click += new System.EventHandler(this.btnStartMaintMonitor_Click);
         // 
         // btnStopMaintMonitor
         // 
         this.btnStopMaintMonitor.Enabled = false;
         this.btnStopMaintMonitor.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
         this.btnStopMaintMonitor.Location = new System.Drawing.Point(314, 55);
         this.btnStopMaintMonitor.Margin = new System.Windows.Forms.Padding(10);
         this.btnStopMaintMonitor.Name = "btnStopMaintMonitor";
         this.btnStopMaintMonitor.Size = new System.Drawing.Size(186, 26);
         this.btnStopMaintMonitor.TabIndex = 25;
         this.btnStopMaintMonitor.Text = "Stop Maint Monitor";
         this.btnStopMaintMonitor.UseVisualStyleBackColor = true;
         this.btnStopMaintMonitor.Click += new System.EventHandler(this.btnStopMaintMonitor_Click);
         // 
         // lstLog
         // 
         this.lstLog.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.lstLog.Font = new System.Drawing.Font("Sarasa Fixed TC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
         this.lstLog.FormattingEnabled = true;
         this.lstLog.ItemHeight = 15;
         this.lstLog.Location = new System.Drawing.Point(0, 427);
         this.lstLog.Name = "lstLog";
         this.lstLog.Size = new System.Drawing.Size(786, 124);
         this.lstLog.TabIndex = 10;
         // 
         // lblStatus
         // 
         this.lblStatus.BackColor = System.Drawing.Color.LightGreen;
         this.lblStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.lblStatus.Location = new System.Drawing.Point(0, 551);
         this.lblStatus.Name = "lblStatus";
         this.lblStatus.Size = new System.Drawing.Size(786, 24);
         this.lblStatus.TabIndex = 11;
         this.lblStatus.Text = "Status";
         this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // grpAlarm
         // 
         this.grpAlarm.Controls.Add(this.btnDeleteAlarm);
         this.grpAlarm.Controls.Add(this.btnAlarmReset);
         this.grpAlarm.Controls.Add(this.txtAlarmCode);
         this.grpAlarm.Controls.Add(this.btnAddAlarm);
         this.grpAlarm.Location = new System.Drawing.Point(253, 18);
         this.grpAlarm.Name = "grpAlarm";
         this.grpAlarm.Size = new System.Drawing.Size(112, 172);
         this.grpAlarm.TabIndex = 26;
         this.grpAlarm.TabStop = false;
         this.grpAlarm.Text = "警報測試";
         // 
         // btnDeleteAlarm
         // 
         this.btnDeleteAlarm.Location = new System.Drawing.Point(7, 59);
         this.btnDeleteAlarm.Margin = new System.Windows.Forms.Padding(10);
         this.btnDeleteAlarm.Name = "btnDeleteAlarm";
         this.btnDeleteAlarm.Size = new System.Drawing.Size(92, 26);
         this.btnDeleteAlarm.TabIndex = 25;
         this.btnDeleteAlarm.Text = "Delete Alarm";
         this.btnDeleteAlarm.UseVisualStyleBackColor = true;
         this.btnDeleteAlarm.Click += new System.EventHandler(this.btnDeleteAlarm_Click);
         // 
         // btnAlarmReset
         // 
         this.btnAlarmReset.Location = new System.Drawing.Point(11, 133);
         this.btnAlarmReset.Margin = new System.Windows.Forms.Padding(10);
         this.btnAlarmReset.Name = "btnAlarmReset";
         this.btnAlarmReset.Size = new System.Drawing.Size(92, 26);
         this.btnAlarmReset.TabIndex = 24;
         this.btnAlarmReset.Text = "Alarm Reset";
         this.btnAlarmReset.UseVisualStyleBackColor = true;
         this.btnAlarmReset.Click += new System.EventHandler(this.btnAlarmReset_Click);
         // 
         // txtAlarmCode
         // 
         this.txtAlarmCode.Location = new System.Drawing.Point(7, 98);
         this.txtAlarmCode.Name = "txtAlarmCode";
         this.txtAlarmCode.Size = new System.Drawing.Size(92, 22);
         this.txtAlarmCode.TabIndex = 23;
         // 
         // btnAddAlarm
         // 
         this.btnAddAlarm.Location = new System.Drawing.Point(7, 21);
         this.btnAddAlarm.Margin = new System.Windows.Forms.Padding(10);
         this.btnAddAlarm.Name = "btnAddAlarm";
         this.btnAddAlarm.Size = new System.Drawing.Size(92, 26);
         this.btnAddAlarm.TabIndex = 22;
         this.btnAddAlarm.Text = "Add Alarm";
         this.btnAddAlarm.UseVisualStyleBackColor = true;
         this.btnAddAlarm.Click += new System.EventHandler(this.btnAddAlarm_Click);
         // 
         // btnRecipeCheck
         // 
         this.btnRecipeCheck.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
         this.btnRecipeCheck.Location = new System.Drawing.Point(15, 21);
         this.btnRecipeCheck.Margin = new System.Windows.Forms.Padding(10);
         this.btnRecipeCheck.Name = "btnRecipeCheck";
         this.btnRecipeCheck.Size = new System.Drawing.Size(142, 26);
         this.btnRecipeCheck.TabIndex = 30;
         this.btnRecipeCheck.Text = "Recipe Check";
         this.btnRecipeCheck.UseVisualStyleBackColor = true;
         this.btnRecipeCheck.Click += new System.EventHandler(this.btnRecipeCheck_Click);
         // 
         // textBox1
         // 
         this.textBox1.Location = new System.Drawing.Point(180, 179);
         this.textBox1.Name = "textBox1";
         this.textBox1.Size = new System.Drawing.Size(100, 22);
         this.textBox1.TabIndex = 29;
         this.textBox1.Text = "0";
         // 
         // btnHandshake
         // 
         this.btnHandshake.Location = new System.Drawing.Point(77, 55);
         this.btnHandshake.Margin = new System.Windows.Forms.Padding(10);
         this.btnHandshake.Name = "btnHandshake";
         this.btnHandshake.Size = new System.Drawing.Size(181, 26);
         this.btnHandshake.TabIndex = 28;
         this.btnHandshake.Text = "交握資料管理";
         this.btnHandshake.UseVisualStyleBackColor = true;
         this.btnHandshake.Click += new System.EventHandler(this.btnHandshake_Click);
         // 
         // btnManualRun
         // 
         this.btnManualRun.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
         this.btnManualRun.Location = new System.Drawing.Point(339, 197);
         this.btnManualRun.Margin = new System.Windows.Forms.Padding(10);
         this.btnManualRun.Name = "btnManualRun";
         this.btnManualRun.Size = new System.Drawing.Size(186, 26);
         this.btnManualRun.TabIndex = 27;
         this.btnManualRun.Text = "Manual Run";
         this.btnManualRun.UseVisualStyleBackColor = true;
         this.btnManualRun.Click += new System.EventHandler(this.btnManualRun_Click);
         // 
         // btnAutoRun
         // 
         this.btnAutoRun.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
         this.btnAutoRun.Location = new System.Drawing.Point(339, 165);
         this.btnAutoRun.Margin = new System.Windows.Forms.Padding(10);
         this.btnAutoRun.Name = "btnAutoRun";
         this.btnAutoRun.Size = new System.Drawing.Size(186, 26);
         this.btnAutoRun.TabIndex = 26;
         this.btnAutoRun.Text = "Auto Run";
         this.btnAutoRun.UseVisualStyleBackColor = true;
         this.btnAutoRun.Click += new System.EventHandler(this.btnAutoRun_Click);
         // 
         // ltbErrorCodes
         // 
         this.ltbErrorCodes.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.ltbErrorCodes.FormattingEnabled = true;
         this.ltbErrorCodes.ItemHeight = 14;
         this.ltbErrorCodes.Location = new System.Drawing.Point(6, 18);
         this.ltbErrorCodes.Name = "ltbErrorCodes";
         this.ltbErrorCodes.Size = new System.Drawing.Size(194, 172);
         this.ltbErrorCodes.TabIndex = 28;
         // 
         // tmrScan
         // 
         this.tmrScan.Enabled = true;
         this.tmrScan.Interval = 500;
         this.tmrScan.Tick += new System.EventHandler(this.tmrScan_Tick);
         // 
         // btnShowPlcSimulatorForm
         // 
         this.btnShowPlcSimulatorForm.Location = new System.Drawing.Point(482, 125);
         this.btnShowPlcSimulatorForm.Name = "btnShowPlcSimulatorForm";
         this.btnShowPlcSimulatorForm.Size = new System.Drawing.Size(150, 25);
         this.btnShowPlcSimulatorForm.TabIndex = 29;
         this.btnShowPlcSimulatorForm.Text = "開啟PLC模擬器";
         this.btnShowPlcSimulatorForm.UseVisualStyleBackColor = true;
         this.btnShowPlcSimulatorForm.Click += new System.EventHandler(this.btnShowPlcSimulatorForm_Click);
         // 
         // btnLotMixingPrevention
         // 
         this.btnLotMixingPrevention.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
         this.btnLotMixingPrevention.Location = new System.Drawing.Point(29, 17);
         this.btnLotMixingPrevention.Name = "btnLotMixingPrevention";
         this.btnLotMixingPrevention.Size = new System.Drawing.Size(150, 25);
         this.btnLotMixingPrevention.TabIndex = 30;
         this.btnLotMixingPrevention.Text = "開啟防混批控制";
         this.btnLotMixingPrevention.UseVisualStyleBackColor = true;
         this.btnLotMixingPrevention.Click += new System.EventHandler(this.btnLotMixingPrevention_Click);
         // 
         // btnShowPosTrackingDataForm
         // 
         this.btnShowPosTrackingDataForm.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
         this.btnShowPosTrackingDataForm.Location = new System.Drawing.Point(282, 120);
         this.btnShowPosTrackingDataForm.Name = "btnShowPosTrackingDataForm";
         this.btnShowPosTrackingDataForm.Size = new System.Drawing.Size(150, 25);
         this.btnShowPosTrackingDataForm.TabIndex = 31;
         this.btnShowPosTrackingDataForm.Text = "開啟位置資料";
         this.btnShowPosTrackingDataForm.UseVisualStyleBackColor = true;
         this.btnShowPosTrackingDataForm.Click += new System.EventHandler(this.btnShowPosTrackingDataForm_Click);
         // 
         // tabMain
         // 
         this.tabMain.Controls.Add(this.tpBasic);
         this.tabMain.Controls.Add(this.tpCheckClock);
         this.tabMain.Controls.Add(this.tpClockUpdate);
         this.tabMain.Controls.Add(this.tpMoveOut);
         this.tabMain.Controls.Add(this.tpRecipeCheck);
         this.tabMain.Controls.Add(this.tpAlarm);
         this.tabMain.Controls.Add(this.tpCommonReport);
         this.tabMain.Controls.Add(this.tpMaintenance);
         this.tabMain.Controls.Add(this.tpTrackingData);
         this.tabMain.Controls.Add(this.tpPosReport);
         this.tabMain.Controls.Add(this.tpLotMixingPrevention);
         this.tabMain.Controls.Add(this.tpLinkReport);
         this.tabMain.Controls.Add(this.tpHandshake);
         this.tabMain.Location = new System.Drawing.Point(0, 3);
         this.tabMain.Multiline = true;
         this.tabMain.Name = "tabMain";
         this.tabMain.SelectedIndex = 0;
         this.tabMain.Size = new System.Drawing.Size(780, 418);
         this.tabMain.TabIndex = 32;
         // 
         // tpBasic
         // 
         this.tpBasic.Controls.Add(this.grpConnectionMode);
         this.tpBasic.Controls.Add(this.grpConnectMode);
         this.tpBasic.Controls.Add(this.btnShowPlcSimulatorForm);
         this.tpBasic.Controls.Add(this.btnOpen);
         this.tpBasic.Controls.Add(this.btnStopSimulator);
         this.tpBasic.Controls.Add(this.btnClose);
         this.tpBasic.Controls.Add(this.btnScanMonitor);
         this.tpBasic.Controls.Add(this.btnPlcSettings);
         this.tpBasic.Location = new System.Drawing.Point(4, 44);
         this.tpBasic.Name = "tpBasic";
         this.tpBasic.Padding = new System.Windows.Forms.Padding(3);
         this.tpBasic.Size = new System.Drawing.Size(772, 370);
         this.tpBasic.TabIndex = 3;
         this.tpBasic.Text = "Basic";
         this.tpBasic.UseVisualStyleBackColor = true;
         // 
         // tpCheckClock
         // 
         this.tpCheckClock.Controls.Add(this.btnStartHeartbeat);
         this.tpCheckClock.Controls.Add(this.btnStopHeartbeat);
         this.tpCheckClock.Location = new System.Drawing.Point(4, 44);
         this.tpCheckClock.Name = "tpCheckClock";
         this.tpCheckClock.Padding = new System.Windows.Forms.Padding(3);
         this.tpCheckClock.Size = new System.Drawing.Size(772, 370);
         this.tpCheckClock.TabIndex = 0;
         this.tpCheckClock.Text = "Check Clock";
         this.tpCheckClock.UseVisualStyleBackColor = true;
         // 
         // tpClockUpdate
         // 
         this.tpClockUpdate.Controls.Add(this.grpManualTime);
         this.tpClockUpdate.Controls.Add(this.btnForceTimeSync);
         this.tpClockUpdate.Controls.Add(this.btnStartTimeSync);
         this.tpClockUpdate.Controls.Add(this.btnStopTimeSync);
         this.tpClockUpdate.Location = new System.Drawing.Point(4, 44);
         this.tpClockUpdate.Name = "tpClockUpdate";
         this.tpClockUpdate.Padding = new System.Windows.Forms.Padding(3);
         this.tpClockUpdate.Size = new System.Drawing.Size(772, 370);
         this.tpClockUpdate.TabIndex = 1;
         this.tpClockUpdate.Text = "Clock Update";
         this.tpClockUpdate.UseVisualStyleBackColor = true;
         // 
         // tpMoveOut
         // 
         this.tpMoveOut.Location = new System.Drawing.Point(4, 44);
         this.tpMoveOut.Name = "tpMoveOut";
         this.tpMoveOut.Size = new System.Drawing.Size(772, 370);
         this.tpMoveOut.TabIndex = 4;
         this.tpMoveOut.Text = "Move Out";
         this.tpMoveOut.UseVisualStyleBackColor = true;
         // 
         // tpRecipeCheck
         // 
         this.tpRecipeCheck.Controls.Add(this.btnRecipeCheck);
         this.tpRecipeCheck.Location = new System.Drawing.Point(4, 44);
         this.tpRecipeCheck.Name = "tpRecipeCheck";
         this.tpRecipeCheck.Size = new System.Drawing.Size(772, 370);
         this.tpRecipeCheck.TabIndex = 5;
         this.tpRecipeCheck.Text = "Recipe Check";
         this.tpRecipeCheck.UseVisualStyleBackColor = true;
         // 
         // tpAlarm
         // 
         this.tpAlarm.Controls.Add(this.ltbErrorCodes);
         this.tpAlarm.Controls.Add(this.grpAlarm);
         this.tpAlarm.Location = new System.Drawing.Point(4, 44);
         this.tpAlarm.Name = "tpAlarm";
         this.tpAlarm.Padding = new System.Windows.Forms.Padding(3);
         this.tpAlarm.Size = new System.Drawing.Size(772, 370);
         this.tpAlarm.TabIndex = 2;
         this.tpAlarm.Text = "Alarm";
         this.tpAlarm.UseVisualStyleBackColor = true;
         // 
         // tpCommonReport
         // 
         this.tpCommonReport.Controls.Add(this.btnSetCommonReporting);
         this.tpCommonReport.Controls.Add(this.btnStartCommonReporting);
         this.tpCommonReport.Controls.Add(this.textBox1);
         this.tpCommonReport.Controls.Add(this.btnAutoRun);
         this.tpCommonReport.Controls.Add(this.btnManualRun);
         this.tpCommonReport.Location = new System.Drawing.Point(4, 44);
         this.tpCommonReport.Name = "tpCommonReport";
         this.tpCommonReport.Padding = new System.Windows.Forms.Padding(3);
         this.tpCommonReport.Size = new System.Drawing.Size(772, 370);
         this.tpCommonReport.TabIndex = 6;
         this.tpCommonReport.Text = "Common Report";
         this.tpCommonReport.UseVisualStyleBackColor = true;
         // 
         // tpMaintenance
         // 
         this.tpMaintenance.Controls.Add(this.btnStartMaintMonitor);
         this.tpMaintenance.Controls.Add(this.btnStopMaintMonitor);
         this.tpMaintenance.Location = new System.Drawing.Point(4, 44);
         this.tpMaintenance.Name = "tpMaintenance";
         this.tpMaintenance.Padding = new System.Windows.Forms.Padding(3);
         this.tpMaintenance.Size = new System.Drawing.Size(772, 370);
         this.tpMaintenance.TabIndex = 7;
         this.tpMaintenance.Text = "Maintenance";
         this.tpMaintenance.UseVisualStyleBackColor = true;
         // 
         // tpTrackingData
         // 
         this.tpTrackingData.Controls.Add(this.btnTrackingControl);
         this.tpTrackingData.Location = new System.Drawing.Point(4, 44);
         this.tpTrackingData.Name = "tpTrackingData";
         this.tpTrackingData.Padding = new System.Windows.Forms.Padding(3);
         this.tpTrackingData.Size = new System.Drawing.Size(772, 370);
         this.tpTrackingData.TabIndex = 8;
         this.tpTrackingData.Text = "Tracking Data";
         this.tpTrackingData.UseVisualStyleBackColor = true;
         // 
         // tpPosReport
         // 
         this.tpPosReport.Controls.Add(this.btnShowPosTrackingDataForm);
         this.tpPosReport.Location = new System.Drawing.Point(4, 44);
         this.tpPosReport.Name = "tpPosReport";
         this.tpPosReport.Padding = new System.Windows.Forms.Padding(3);
         this.tpPosReport.Size = new System.Drawing.Size(772, 370);
         this.tpPosReport.TabIndex = 9;
         this.tpPosReport.Text = "Position Report";
         this.tpPosReport.UseVisualStyleBackColor = true;
         // 
         // tpLotMixingPrevention
         // 
         this.tpLotMixingPrevention.Controls.Add(this.btnLotMixingPrevention);
         this.tpLotMixingPrevention.Location = new System.Drawing.Point(4, 44);
         this.tpLotMixingPrevention.Name = "tpLotMixingPrevention";
         this.tpLotMixingPrevention.Padding = new System.Windows.Forms.Padding(3);
         this.tpLotMixingPrevention.Size = new System.Drawing.Size(772, 370);
         this.tpLotMixingPrevention.TabIndex = 10;
         this.tpLotMixingPrevention.Text = "Lot Mixing Prevention";
         this.tpLotMixingPrevention.UseVisualStyleBackColor = true;
         // 
         // tpLinkReport
         // 
         this.tpLinkReport.Controls.Add(this.btnStartLinkReport);
         this.tpLinkReport.Controls.Add(this.btnStopLinkReport);
         this.tpLinkReport.Controls.Add(this.btnSendLinkData);
         this.tpLinkReport.Location = new System.Drawing.Point(4, 44);
         this.tpLinkReport.Name = "tpLinkReport";
         this.tpLinkReport.Padding = new System.Windows.Forms.Padding(3);
         this.tpLinkReport.Size = new System.Drawing.Size(772, 370);
         this.tpLinkReport.TabIndex = 11;
         this.tpLinkReport.Text = "Link Report";
         this.tpLinkReport.UseVisualStyleBackColor = true;
         // 
         // tpHandshake
         // 
         this.tpHandshake.Controls.Add(this.btnHandshake);
         this.tpHandshake.Location = new System.Drawing.Point(4, 44);
         this.tpHandshake.Name = "tpHandshake";
         this.tpHandshake.Padding = new System.Windows.Forms.Padding(3);
         this.tpHandshake.Size = new System.Drawing.Size(772, 370);
         this.tpHandshake.TabIndex = 12;
         this.tpHandshake.Text = "Handshake";
         this.tpHandshake.UseVisualStyleBackColor = true;
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
         this.ClientSize = new System.Drawing.Size(786, 575);
         this.Controls.Add(this.tabMain);
         this.Controls.Add(this.lstLog);
         this.Controls.Add(this.lblStatus);
         this.Font = new System.Drawing.Font("更紗黑體 UI TC", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
         this.Name = "Form1";
         this.Text = "CC-Link Helper";
         this.grpConnectionMode.ResumeLayout(false);
         this.grpManualTime.ResumeLayout(false);
         this.grpConnectMode.ResumeLayout(false);
         this.grpConnectMode.PerformLayout();
         this.grpAlarm.ResumeLayout(false);
         this.grpAlarm.PerformLayout();
         this.tabMain.ResumeLayout(false);
         this.tpBasic.ResumeLayout(false);
         this.tpBasic.PerformLayout();
         this.tpCheckClock.ResumeLayout(false);
         this.tpClockUpdate.ResumeLayout(false);
         this.tpClockUpdate.PerformLayout();
         this.tpRecipeCheck.ResumeLayout(false);
         this.tpAlarm.ResumeLayout(false);
         this.tpCommonReport.ResumeLayout(false);
         this.tpCommonReport.PerformLayout();
         this.tpMaintenance.ResumeLayout(false);
         this.tpTrackingData.ResumeLayout(false);
         this.tpPosReport.ResumeLayout(false);
         this.tpLotMixingPrevention.ResumeLayout(false);
         this.tpLinkReport.ResumeLayout(false);
         this.tpHandshake.ResumeLayout(false);
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.GroupBox grpConnectionMode;
      private System.Windows.Forms.ComboBox cmbDriverType;
      private System.Windows.Forms.Button btnOpen;
      private System.Windows.Forms.Button btnClose;
      private System.Windows.Forms.Button btnStartTimeSync;
      private System.Windows.Forms.Button btnStopTimeSync;
      private System.Windows.Forms.Button btnForceTimeSync;
      private System.Windows.Forms.ListBox lstLog;
      private System.Windows.Forms.Label lblStatus;
      private System.Windows.Forms.GroupBox grpManualTime;
      private System.Windows.Forms.DateTimePicker dtpDate;
      private System.Windows.Forms.DateTimePicker dtpTime;
      private System.Windows.Forms.Button btnSetTimeToPlc;
      private System.Windows.Forms.Button btnSyncFromPc;
      private System.Windows.Forms.Button btnStartHeartbeat;
      private System.Windows.Forms.Button btnStopSimulator;
      private System.Windows.Forms.Button btnPlcSettings;
      private System.Windows.Forms.Button btnStopHeartbeat;
      private System.Windows.Forms.Button btnScanMonitor;
      private System.Windows.Forms.Button btnTrackingControl;
      private System.Windows.Forms.Button btnSetCommonReporting;
      private System.Windows.Forms.GroupBox grpCommonReportStatus1;
      private System.Windows.Forms.NumericUpDown nudAlarmStatus;
      private System.Windows.Forms.NumericUpDown nudMachineStatus;
      private System.Windows.Forms.NumericUpDown nudActionStatus;
      private System.Windows.Forms.NumericUpDown nudWaitingStatus;
      private System.Windows.Forms.NumericUpDown nudControlStatus;
      private System.Windows.Forms.Label lblAlarmStatus;
      private System.Windows.Forms.Label lblMachineStatus;
      private System.Windows.Forms.Label lblActionStatus;
      private System.Windows.Forms.Label lblWaitingStatus;
      private System.Windows.Forms.Label lblControlStatus;
      private System.Windows.Forms.Button btnStartCommonReporting;
      private System.Windows.Forms.Button btnStartLinkReport;
      private System.Windows.Forms.Button btnStopLinkReport;
      private System.Windows.Forms.Button btnSendLinkData;
      private System.Windows.Forms.GroupBox grpConnectMode;
      private System.Windows.Forms.RadioButton rbtnOffline;
      private System.Windows.Forms.RadioButton rbtnOnline;
      private System.Windows.Forms.Button btnStartMaintMonitor;
      private System.Windows.Forms.Button btnStopMaintMonitor;
      private System.Windows.Forms.GroupBox grpAlarm;
      private System.Windows.Forms.TextBox txtAlarmCode;
      private System.Windows.Forms.Button btnAddAlarm;
      private System.Windows.Forms.ListBox ltbErrorCodes;
      private System.Windows.Forms.Timer tmrScan;
      private System.Windows.Forms.Button btnAlarmReset;
      private System.Windows.Forms.Button btnManualRun;
      private System.Windows.Forms.Button btnAutoRun;
      private System.Windows.Forms.Button btnDeleteAlarm;
      private System.Windows.Forms.Button btnHandshake;
      private System.Windows.Forms.TextBox textBox1;
      private System.Windows.Forms.Button btnRecipeCheck;
      private System.Windows.Forms.Button btnShowPlcSimulatorForm;
      private System.Windows.Forms.Button btnLotMixingPrevention;
      private System.Windows.Forms.Button btnShowPosTrackingDataForm;
      private System.Windows.Forms.TabControl tabMain;
      private System.Windows.Forms.TabPage tpBasic;
      private System.Windows.Forms.TabPage tpCheckClock;
      private System.Windows.Forms.TabPage tpClockUpdate;
      private System.Windows.Forms.TabPage tpMoveOut;
      private System.Windows.Forms.TabPage tpRecipeCheck;
      private System.Windows.Forms.TabPage tpAlarm;
      private System.Windows.Forms.TabPage tpCommonReport;
      private System.Windows.Forms.TabPage tpMaintenance;
      private System.Windows.Forms.TabPage tpTrackingData;
      private System.Windows.Forms.TabPage tpPosReport;
      private System.Windows.Forms.TabPage tpLotMixingPrevention;
      private System.Windows.Forms.TabPage tpLinkReport;
      private System.Windows.Forms.TabPage tpHandshake;
   }
}


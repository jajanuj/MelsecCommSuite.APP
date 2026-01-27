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
         this.cboPlcMoveOutTestMode = new System.Windows.Forms.ComboBox();
         this.lblPlcTestMode = new System.Windows.Forms.Label();
         this.tlpMoveOutData = new System.Windows.Forms.TableLayoutPanel();
         this.label2 = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.nudJudge3 = new System.Windows.Forms.NumericUpDown();
         this.panel1 = new System.Windows.Forms.Panel();
         this.label8 = new System.Windows.Forms.Label();
         this.nudBoardId1 = new System.Windows.Forms.NumericUpDown();
         this.nudBoardId2 = new System.Windows.Forms.NumericUpDown();
         this.nudBoardId3 = new System.Windows.Forms.NumericUpDown();
         this.label9 = new System.Windows.Forms.Label();
         this.nudJudge2 = new System.Windows.Forms.NumericUpDown();
         this.nudLayerCount = new System.Windows.Forms.NumericUpDown();
         this.label10 = new System.Windows.Forms.Label();
         this.nudJudge1 = new System.Windows.Forms.NumericUpDown();
         this.txtLotChar = new System.Windows.Forms.TextBox();
         this.label12 = new System.Windows.Forms.Label();
         this.label11 = new System.Windows.Forms.Label();
         this.nudLotNum = new System.Windows.Forms.NumericUpDown();
         this.btnMoveOutStop = new System.Windows.Forms.Button();
         this.btnMoveOutStart = new System.Windows.Forms.Button();
         this.tpRecipeCheck = new System.Windows.Forms.TabPage();
         this.tpAlarm = new System.Windows.Forms.TabPage();
         this.tpCommonReport = new System.Windows.Forms.TabPage();
         this.tpMaintenance = new System.Windows.Forms.TabPage();
         this.tpTrackingData = new System.Windows.Forms.TabPage();
         this.tpPosReport = new System.Windows.Forms.TabPage();
         this.tpLotMixingPrevention = new System.Windows.Forms.TabPage();
         this.tpLinkReport = new System.Windows.Forms.TabPage();
         this.tpRegularDataCollectionReport = new System.Windows.Forms.TabPage();
         this.btnStartRegularReport = new System.Windows.Forms.Button();
         this.btnStopRegularReport = new System.Windows.Forms.Button();
         this.tpHandshake = new System.Windows.Forms.TabPage();
         this.paramNgTime = new GRT.SDK.Framework.Component.ParamNumericUpDownUserControl();
         this.paramPdTime = new GRT.SDK.Framework.Component.ParamNumericUpDownUserControl();
         this.btnSetRgvTrackingData = new System.Windows.Forms.Button();
         this.btnMoveToOven1 = new System.Windows.Forms.Button();
         this.paramOvenWorkTime = new GRT.SDK.Framework.Component.ParamNumericUpDownUserControl();
         this.lblOvenWorkTime = new System.Windows.Forms.Label();
         this.grpConnectionMode.SuspendLayout();
         this.grpManualTime.SuspendLayout();
         this.grpConnectMode.SuspendLayout();
         this.grpAlarm.SuspendLayout();
         this.tabMain.SuspendLayout();
         this.tpBasic.SuspendLayout();
         this.tpCheckClock.SuspendLayout();
         this.tpClockUpdate.SuspendLayout();
         this.tpMoveOut.SuspendLayout();
         this.tlpMoveOutData.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.nudJudge3)).BeginInit();
         this.panel1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.nudBoardId1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.nudBoardId2)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.nudBoardId3)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.nudJudge2)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.nudLayerCount)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.nudJudge1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.nudLotNum)).BeginInit();
         this.tpRecipeCheck.SuspendLayout();
         this.tpAlarm.SuspendLayout();
         this.tpCommonReport.SuspendLayout();
         this.tpMaintenance.SuspendLayout();
         this.tpTrackingData.SuspendLayout();
         this.tpPosReport.SuspendLayout();
         this.tpLotMixingPrevention.SuspendLayout();
         this.tpLinkReport.SuspendLayout();
         this.tpRegularDataCollectionReport.SuspendLayout();
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
         this.btnTrackingControl.Location = new System.Drawing.Point(15, 13);
         this.btnTrackingControl.Margin = new System.Windows.Forms.Padding(5);
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
         this.btnStartMaintMonitor.Click += new System.EventHandler(this.btnStartMaintenanceMonitor_Click);
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
         this.btnStopMaintMonitor.Click += new System.EventHandler(this.btnStopMaintenanceMonitor_Click);
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
         this.btnShowPosTrackingDataForm.Location = new System.Drawing.Point(24, 24);
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
         this.tabMain.Controls.Add(this.tpRegularDataCollectionReport);
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
         this.tpMoveOut.Controls.Add(this.cboPlcMoveOutTestMode);
         this.tpMoveOut.Controls.Add(this.lblPlcTestMode);
         this.tpMoveOut.Controls.Add(this.tlpMoveOutData);
         this.tpMoveOut.Controls.Add(this.btnMoveOutStop);
         this.tpMoveOut.Controls.Add(this.btnMoveOutStart);
         this.tpMoveOut.Location = new System.Drawing.Point(4, 44);
         this.tpMoveOut.Name = "tpMoveOut";
         this.tpMoveOut.Size = new System.Drawing.Size(772, 370);
         this.tpMoveOut.TabIndex = 4;
         this.tpMoveOut.Text = "Move Out";
         this.tpMoveOut.UseVisualStyleBackColor = true;
         // 
         // cboPlcMoveOutTestMode
         // 
         this.cboPlcMoveOutTestMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cboPlcMoveOutTestMode.FormattingEnabled = true;
         this.cboPlcMoveOutTestMode.Location = new System.Drawing.Point(306, 180);
         this.cboPlcMoveOutTestMode.Name = "cboPlcMoveOutTestMode";
         this.cboPlcMoveOutTestMode.Size = new System.Drawing.Size(121, 23);
         this.cboPlcMoveOutTestMode.TabIndex = 5;
         this.cboPlcMoveOutTestMode.SelectedIndexChanged += new System.EventHandler(this.cboPlcMoveOutTestMode_SelectedIndexChanged);
         // 
         // lblPlcTestMode
         // 
         this.lblPlcTestMode.AutoSize = true;
         this.lblPlcTestMode.Location = new System.Drawing.Point(207, 183);
         this.lblPlcTestMode.Name = "lblPlcTestMode";
         this.lblPlcTestMode.Size = new System.Drawing.Size(93, 15);
         this.lblPlcTestMode.TabIndex = 4;
         this.lblPlcTestMode.Text = "PLC Test Mode";
         // 
         // tlpMoveOutData
         // 
         this.tlpMoveOutData.ColumnCount = 4;
         this.tlpMoveOutData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
         this.tlpMoveOutData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
         this.tlpMoveOutData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
         this.tlpMoveOutData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
         this.tlpMoveOutData.Controls.Add(this.label2, 2, 3);
         this.tlpMoveOutData.Controls.Add(this.label1, 0, 3);
         this.tlpMoveOutData.Controls.Add(this.nudJudge3, 3, 3);
         this.tlpMoveOutData.Controls.Add(this.panel1, 0, 0);
         this.tlpMoveOutData.Controls.Add(this.label9, 0, 1);
         this.tlpMoveOutData.Controls.Add(this.nudJudge2, 1, 3);
         this.tlpMoveOutData.Controls.Add(this.nudLayerCount, 1, 1);
         this.tlpMoveOutData.Controls.Add(this.label10, 2, 1);
         this.tlpMoveOutData.Controls.Add(this.nudJudge1, 3, 2);
         this.tlpMoveOutData.Controls.Add(this.txtLotChar, 3, 1);
         this.tlpMoveOutData.Controls.Add(this.label12, 2, 2);
         this.tlpMoveOutData.Controls.Add(this.label11, 0, 2);
         this.tlpMoveOutData.Controls.Add(this.nudLotNum, 1, 2);
         this.tlpMoveOutData.Location = new System.Drawing.Point(207, 14);
         this.tlpMoveOutData.Name = "tlpMoveOutData";
         this.tlpMoveOutData.RowCount = 4;
         this.tlpMoveOutData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
         this.tlpMoveOutData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
         this.tlpMoveOutData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
         this.tlpMoveOutData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
         this.tlpMoveOutData.Size = new System.Drawing.Size(360, 144);
         this.tlpMoveOutData.TabIndex = 3;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
         this.label2.Font = new System.Drawing.Font("更紗黑體 UI TC", 9.749999F);
         this.label2.Location = new System.Drawing.Point(185, 118);
         this.label2.Margin = new System.Windows.Forms.Padding(5, 8, 5, 5);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(80, 21);
         this.label2.TabIndex = 17;
         this.label2.Text = "判斷旗標3:";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.label1.Font = new System.Drawing.Font("更紗黑體 UI TC", 9.749999F);
         this.label1.Location = new System.Drawing.Point(5, 118);
         this.label1.Margin = new System.Windows.Forms.Padding(5, 8, 5, 5);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(80, 21);
         this.label1.TabIndex = 16;
         this.label1.Text = "判斷旗標2:";
         // 
         // nudJudge3
         // 
         this.nudJudge3.Dock = System.Windows.Forms.DockStyle.Fill;
         this.nudJudge3.Location = new System.Drawing.Point(275, 115);
         this.nudJudge3.Margin = new System.Windows.Forms.Padding(5);
         this.nudJudge3.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
         this.nudJudge3.Name = "nudJudge3";
         this.nudJudge3.Size = new System.Drawing.Size(80, 22);
         this.nudJudge3.TabIndex = 15;
         this.nudJudge3.Value = new decimal(new int[] {
            77,
            0,
            0,
            0});
         // 
         // panel1
         // 
         this.tlpMoveOutData.SetColumnSpan(this.panel1, 4);
         this.panel1.Controls.Add(this.label8);
         this.panel1.Controls.Add(this.nudBoardId1);
         this.panel1.Controls.Add(this.nudBoardId2);
         this.panel1.Controls.Add(this.nudBoardId3);
         this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.panel1.Location = new System.Drawing.Point(3, 3);
         this.panel1.Name = "panel1";
         this.panel1.Padding = new System.Windows.Forms.Padding(2);
         this.panel1.Size = new System.Drawing.Size(354, 44);
         this.panel1.TabIndex = 4;
         // 
         // label8
         // 
         this.label8.AutoSize = true;
         this.label8.Font = new System.Drawing.Font("更紗黑體 UI TC", 9.749999F);
         this.label8.Location = new System.Drawing.Point(10, 15);
         this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
         this.label8.Name = "label8";
         this.label8.Size = new System.Drawing.Size(63, 16);
         this.label8.TabIndex = 0;
         this.label8.Text = "基板序號:";
         // 
         // nudBoardId1
         // 
         this.nudBoardId1.Location = new System.Drawing.Point(78, 13);
         this.nudBoardId1.Margin = new System.Windows.Forms.Padding(2);
         this.nudBoardId1.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
         this.nudBoardId1.Name = "nudBoardId1";
         this.nudBoardId1.Size = new System.Drawing.Size(53, 22);
         this.nudBoardId1.TabIndex = 1;
         this.nudBoardId1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
         // 
         // nudBoardId2
         // 
         this.nudBoardId2.Location = new System.Drawing.Point(151, 13);
         this.nudBoardId2.Margin = new System.Windows.Forms.Padding(2);
         this.nudBoardId2.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
         this.nudBoardId2.Name = "nudBoardId2";
         this.nudBoardId2.Size = new System.Drawing.Size(53, 22);
         this.nudBoardId2.TabIndex = 2;
         this.nudBoardId2.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
         // 
         // nudBoardId3
         // 
         this.nudBoardId3.Location = new System.Drawing.Point(226, 13);
         this.nudBoardId3.Margin = new System.Windows.Forms.Padding(2);
         this.nudBoardId3.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
         this.nudBoardId3.Name = "nudBoardId3";
         this.nudBoardId3.Size = new System.Drawing.Size(53, 22);
         this.nudBoardId3.TabIndex = 3;
         this.nudBoardId3.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
         // 
         // label9
         // 
         this.label9.AutoSize = true;
         this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
         this.label9.Font = new System.Drawing.Font("更紗黑體 UI TC", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
         this.label9.Location = new System.Drawing.Point(5, 58);
         this.label9.Margin = new System.Windows.Forms.Padding(5, 8, 5, 5);
         this.label9.Name = "label9";
         this.label9.Size = new System.Drawing.Size(80, 17);
         this.label9.TabIndex = 4;
         this.label9.Text = "基板層數:";
         // 
         // nudJudge2
         // 
         this.nudJudge2.Dock = System.Windows.Forms.DockStyle.Fill;
         this.nudJudge2.Location = new System.Drawing.Point(95, 115);
         this.nudJudge2.Margin = new System.Windows.Forms.Padding(5);
         this.nudJudge2.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
         this.nudJudge2.Name = "nudJudge2";
         this.nudJudge2.Size = new System.Drawing.Size(80, 22);
         this.nudJudge2.TabIndex = 13;
         this.nudJudge2.Value = new decimal(new int[] {
            66,
            0,
            0,
            0});
         // 
         // nudLayerCount
         // 
         this.nudLayerCount.Dock = System.Windows.Forms.DockStyle.Fill;
         this.nudLayerCount.Location = new System.Drawing.Point(95, 55);
         this.nudLayerCount.Margin = new System.Windows.Forms.Padding(5);
         this.nudLayerCount.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
         this.nudLayerCount.Name = "nudLayerCount";
         this.nudLayerCount.Size = new System.Drawing.Size(80, 22);
         this.nudLayerCount.TabIndex = 5;
         this.nudLayerCount.Value = new decimal(new int[] {
            44,
            0,
            0,
            0});
         // 
         // label10
         // 
         this.label10.AutoSize = true;
         this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
         this.label10.Font = new System.Drawing.Font("更紗黑體 UI TC", 9.749999F);
         this.label10.Location = new System.Drawing.Point(185, 58);
         this.label10.Margin = new System.Windows.Forms.Padding(5, 8, 5, 5);
         this.label10.Name = "label10";
         this.label10.Size = new System.Drawing.Size(80, 17);
         this.label10.TabIndex = 6;
         this.label10.Text = "批號 (文字):";
         // 
         // nudJudge1
         // 
         this.nudJudge1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.nudJudge1.Location = new System.Drawing.Point(275, 85);
         this.nudJudge1.Margin = new System.Windows.Forms.Padding(5);
         this.nudJudge1.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
         this.nudJudge1.Name = "nudJudge1";
         this.nudJudge1.Size = new System.Drawing.Size(80, 22);
         this.nudJudge1.TabIndex = 11;
         this.nudJudge1.Value = new decimal(new int[] {
            55,
            0,
            0,
            0});
         // 
         // txtLotChar
         // 
         this.txtLotChar.Location = new System.Drawing.Point(280, 55);
         this.txtLotChar.Margin = new System.Windows.Forms.Padding(10, 5, 2, 2);
         this.txtLotChar.MaxLength = 1;
         this.txtLotChar.Name = "txtLotChar";
         this.txtLotChar.Size = new System.Drawing.Size(35, 22);
         this.txtLotChar.TabIndex = 7;
         this.txtLotChar.Text = "A";
         // 
         // label12
         // 
         this.label12.AutoSize = true;
         this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
         this.label12.Font = new System.Drawing.Font("更紗黑體 UI TC", 9.749999F);
         this.label12.Location = new System.Drawing.Point(185, 88);
         this.label12.Margin = new System.Windows.Forms.Padding(5, 8, 5, 5);
         this.label12.Name = "label12";
         this.label12.Size = new System.Drawing.Size(80, 17);
         this.label12.TabIndex = 10;
         this.label12.Text = "判斷旗標1:";
         // 
         // label11
         // 
         this.label11.AutoSize = true;
         this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
         this.label11.Font = new System.Drawing.Font("更紗黑體 UI TC", 9.749999F);
         this.label11.Location = new System.Drawing.Point(5, 88);
         this.label11.Margin = new System.Windows.Forms.Padding(5, 8, 5, 5);
         this.label11.Name = "label11";
         this.label11.Size = new System.Drawing.Size(80, 17);
         this.label11.TabIndex = 8;
         this.label11.Text = "批號 (數字):";
         // 
         // nudLotNum
         // 
         this.nudLotNum.Dock = System.Windows.Forms.DockStyle.Fill;
         this.nudLotNum.Location = new System.Drawing.Point(95, 85);
         this.nudLotNum.Margin = new System.Windows.Forms.Padding(5);
         this.nudLotNum.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
         this.nudLotNum.Name = "nudLotNum";
         this.nudLotNum.Size = new System.Drawing.Size(80, 22);
         this.nudLotNum.TabIndex = 9;
         this.nudLotNum.Value = new decimal(new int[] {
            123456,
            0,
            0,
            0});
         // 
         // btnMoveOutStop
         // 
         this.btnMoveOutStop.Location = new System.Drawing.Point(24, 102);
         this.btnMoveOutStop.Name = "btnMoveOutStop";
         this.btnMoveOutStop.Size = new System.Drawing.Size(131, 23);
         this.btnMoveOutStop.TabIndex = 1;
         this.btnMoveOutStop.Text = "Move Out Stop";
         this.btnMoveOutStop.UseVisualStyleBackColor = true;
         this.btnMoveOutStop.Click += new System.EventHandler(this.btnMoveOutStop_Click);
         // 
         // btnMoveOutStart
         // 
         this.btnMoveOutStart.Location = new System.Drawing.Point(24, 66);
         this.btnMoveOutStart.Name = "btnMoveOutStart";
         this.btnMoveOutStart.Size = new System.Drawing.Size(131, 23);
         this.btnMoveOutStart.TabIndex = 0;
         this.btnMoveOutStart.Text = "Move Out Start";
         this.btnMoveOutStart.UseVisualStyleBackColor = true;
         this.btnMoveOutStart.Click += new System.EventHandler(this.btnMoveOutStart_Click);
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
         this.tpTrackingData.Controls.Add(this.lblOvenWorkTime);
         this.tpTrackingData.Controls.Add(this.paramOvenWorkTime);
         this.tpTrackingData.Controls.Add(this.btnMoveToOven1);
         this.tpTrackingData.Controls.Add(this.btnSetRgvTrackingData);
         this.tpTrackingData.Controls.Add(this.paramPdTime);
         this.tpTrackingData.Controls.Add(this.paramNgTime);
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
         // tpRegularDataCollectionReport
         // 
         this.tpRegularDataCollectionReport.Controls.Add(this.btnStartRegularReport);
         this.tpRegularDataCollectionReport.Controls.Add(this.btnStopRegularReport);
         this.tpRegularDataCollectionReport.Location = new System.Drawing.Point(4, 44);
         this.tpRegularDataCollectionReport.Name = "tpRegularDataCollectionReport";
         this.tpRegularDataCollectionReport.Padding = new System.Windows.Forms.Padding(3);
         this.tpRegularDataCollectionReport.Size = new System.Drawing.Size(772, 370);
         this.tpRegularDataCollectionReport.TabIndex = 13;
         this.tpRegularDataCollectionReport.Text = "Regular Data Collection Report";
         this.tpRegularDataCollectionReport.UseVisualStyleBackColor = true;
         // 
         // btnStartRegularReport
         // 
         this.btnStartRegularReport.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
         this.btnStartRegularReport.Location = new System.Drawing.Point(20, 20);
         this.btnStartRegularReport.Margin = new System.Windows.Forms.Padding(5);
         this.btnStartRegularReport.Name = "btnStartRegularReport";
         this.btnStartRegularReport.Size = new System.Drawing.Size(181, 26);
         this.btnStartRegularReport.TabIndex = 21;
         this.btnStartRegularReport.Text = "Start Regular Report";
         this.btnStartRegularReport.UseVisualStyleBackColor = true;
         this.btnStartRegularReport.Click += new System.EventHandler(this.btnStartRegularReport_Click);
         // 
         // btnStopRegularReport
         // 
         this.btnStopRegularReport.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
         this.btnStopRegularReport.Location = new System.Drawing.Point(20, 56);
         this.btnStopRegularReport.Margin = new System.Windows.Forms.Padding(5);
         this.btnStopRegularReport.Name = "btnStopRegularReport";
         this.btnStopRegularReport.Size = new System.Drawing.Size(181, 26);
         this.btnStopRegularReport.TabIndex = 22;
         this.btnStopRegularReport.Text = "Stop Regular Report";
         this.btnStopRegularReport.UseVisualStyleBackColor = true;
         this.btnStopRegularReport.Click += new System.EventHandler(this.btnStopRegularReport_Click);
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
         // paramNgTime
         // 
         this.paramNgTime.Caption = "NG Time(sec)";
         this.paramNgTime.CaptionWidth = 75F;
         this.paramNgTime.DecimalPlaces = 1;
         this.paramNgTime.Font = new System.Drawing.Font("更紗黑體 UI TC", 9.749999F);
         this.paramNgTime.Increment = 60D;
         this.paramNgTime.Location = new System.Drawing.Point(15, 138);
         this.paramNgTime.MaxNumber = 3600D;
         this.paramNgTime.MinimumSize = new System.Drawing.Size(171, 30);
         this.paramNgTime.MinNumber = 10D;
         this.paramNgTime.Name = "paramNgTime";
         this.paramNgTime.Size = new System.Drawing.Size(314, 30);
         this.paramNgTime.TabIndex = 19;
         this.paramNgTime.Value = 20D;
         // 
         // paramPdTime
         // 
         this.paramPdTime.Caption = "PD Time(sec)";
         this.paramPdTime.CaptionWidth = 75F;
         this.paramPdTime.DecimalPlaces = 1;
         this.paramPdTime.Font = new System.Drawing.Font("更紗黑體 UI TC", 9.749999F);
         this.paramPdTime.Increment = 60D;
         this.paramPdTime.Location = new System.Drawing.Point(15, 102);
         this.paramPdTime.MaxNumber = 3600D;
         this.paramPdTime.MinimumSize = new System.Drawing.Size(171, 30);
         this.paramPdTime.MinNumber = 10D;
         this.paramPdTime.Name = "paramPdTime";
         this.paramPdTime.Size = new System.Drawing.Size(314, 30);
         this.paramPdTime.TabIndex = 20;
         this.paramPdTime.Value = 10D;
         // 
         // btnSetRgvTrackingData
         // 
         this.btnSetRgvTrackingData.Location = new System.Drawing.Point(13, 176);
         this.btnSetRgvTrackingData.Margin = new System.Windows.Forms.Padding(5);
         this.btnSetRgvTrackingData.Name = "btnSetRgvTrackingData";
         this.btnSetRgvTrackingData.Size = new System.Drawing.Size(181, 26);
         this.btnSetRgvTrackingData.TabIndex = 21;
         this.btnSetRgvTrackingData.Text = "Set RGV Tracking Data";
         this.btnSetRgvTrackingData.UseVisualStyleBackColor = true;
         this.btnSetRgvTrackingData.Click += new System.EventHandler(this.btnSetRgvTrackingData_Click);
         // 
         // btnMoveToOven1
         // 
         this.btnMoveToOven1.Location = new System.Drawing.Point(13, 212);
         this.btnMoveToOven1.Margin = new System.Windows.Forms.Padding(5);
         this.btnMoveToOven1.Name = "btnMoveToOven1";
         this.btnMoveToOven1.Size = new System.Drawing.Size(181, 26);
         this.btnMoveToOven1.TabIndex = 22;
         this.btnMoveToOven1.Text = "Move To Oven1";
         this.btnMoveToOven1.UseVisualStyleBackColor = true;
         this.btnMoveToOven1.Click += new System.EventHandler(this.btnMoveToOven1_Click);
         // 
         // paramOvenWorkTime
         // 
         this.paramOvenWorkTime.Caption = "Oven Work Time(sec)";
         this.paramOvenWorkTime.CaptionWidth = 75F;
         this.paramOvenWorkTime.DecimalPlaces = 1;
         this.paramOvenWorkTime.Font = new System.Drawing.Font("更紗黑體 UI TC", 9.749999F);
         this.paramOvenWorkTime.Increment = 60D;
         this.paramOvenWorkTime.Location = new System.Drawing.Point(15, 66);
         this.paramOvenWorkTime.MaxNumber = 3600D;
         this.paramOvenWorkTime.MinimumSize = new System.Drawing.Size(171, 30);
         this.paramOvenWorkTime.MinNumber = 10D;
         this.paramOvenWorkTime.Name = "paramOvenWorkTime";
         this.paramOvenWorkTime.Size = new System.Drawing.Size(314, 30);
         this.paramOvenWorkTime.TabIndex = 23;
         this.paramOvenWorkTime.Value = 15D;
         // 
         // lblOvenWorkTime
         // 
         this.lblOvenWorkTime.Font = new System.Drawing.Font("更紗黑體 UI TC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
         this.lblOvenWorkTime.Location = new System.Drawing.Point(11, 261);
         this.lblOvenWorkTime.Name = "lblOvenWorkTime";
         this.lblOvenWorkTime.Size = new System.Drawing.Size(183, 24);
         this.lblOvenWorkTime.TabIndex = 24;
         this.lblOvenWorkTime.Text = "00:00:00";
         this.lblOvenWorkTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
         this.tpMoveOut.ResumeLayout(false);
         this.tpMoveOut.PerformLayout();
         this.tlpMoveOutData.ResumeLayout(false);
         this.tlpMoveOutData.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.nudJudge3)).EndInit();
         this.panel1.ResumeLayout(false);
         this.panel1.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.nudBoardId1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.nudBoardId2)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.nudBoardId3)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.nudJudge2)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.nudLayerCount)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.nudJudge1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.nudLotNum)).EndInit();
         this.tpRecipeCheck.ResumeLayout(false);
         this.tpAlarm.ResumeLayout(false);
         this.tpCommonReport.ResumeLayout(false);
         this.tpCommonReport.PerformLayout();
         this.tpMaintenance.ResumeLayout(false);
         this.tpTrackingData.ResumeLayout(false);
         this.tpPosReport.ResumeLayout(false);
         this.tpLotMixingPrevention.ResumeLayout(false);
         this.tpLinkReport.ResumeLayout(false);
         this.tpRegularDataCollectionReport.ResumeLayout(false);
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
      private System.Windows.Forms.Button btnMoveOutStart;
      private System.Windows.Forms.Button btnMoveOutStop;
      private System.Windows.Forms.TableLayoutPanel tlpMoveOutData;
      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.Label label8;
      private System.Windows.Forms.NumericUpDown nudBoardId1;
      private System.Windows.Forms.NumericUpDown nudBoardId2;
      private System.Windows.Forms.NumericUpDown nudBoardId3;
      private System.Windows.Forms.Label label9;
      private System.Windows.Forms.NumericUpDown nudLayerCount;
      private System.Windows.Forms.Label label10;
      private System.Windows.Forms.TextBox txtLotChar;
      private System.Windows.Forms.NumericUpDown nudJudge3;
      private System.Windows.Forms.NumericUpDown nudJudge2;
      private System.Windows.Forms.NumericUpDown nudJudge1;
      private System.Windows.Forms.Label label12;
      private System.Windows.Forms.NumericUpDown nudLotNum;
      private System.Windows.Forms.Label label11;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.ComboBox cboPlcMoveOutTestMode;
      private System.Windows.Forms.Label lblPlcTestMode;
      private System.Windows.Forms.TabPage tpRegularDataCollectionReport;
      private System.Windows.Forms.Button btnStartRegularReport;
      private System.Windows.Forms.Button btnStopRegularReport;
      private GRT.SDK.Framework.Component.ParamNumericUpDownUserControl paramPdTime;
      private GRT.SDK.Framework.Component.ParamNumericUpDownUserControl paramNgTime;
      private System.Windows.Forms.Button btnMoveToOven1;
      private System.Windows.Forms.Button btnSetRgvTrackingData;
      private GRT.SDK.Framework.Component.ParamNumericUpDownUserControl paramOvenWorkTime;
      private System.Windows.Forms.Label lblOvenWorkTime;
   }
}


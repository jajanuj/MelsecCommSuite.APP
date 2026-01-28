namespace MelsecHelper.APP.Forms
{
   partial class MelsecBoardSettingForm
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.tabApp = new System.Windows.Forms.TabPage();
         this.paramHeartbeatInterval = new GRT.SDK.Framework.Component.ParamNumericUpDownUserControl();
         this.paramHeartbeatResponseAddress = new GRT.SDK.Framework.Component.ParamTextUserControl();
         this.paramHeartbeatRequestAddress = new GRT.SDK.Framework.Component.ParamTextUserControl();
         this.label11 = new System.Windows.Forms.Label();
         this.numTimeSync = new System.Windows.Forms.NumericUpDown();
         this.label12 = new System.Windows.Forms.Label();
         this.txtTrigger = new System.Windows.Forms.TextBox();
         this.label13 = new System.Windows.Forms.Label();
         this.txtData = new System.Windows.Forms.TextBox();
         this.tabTracking = new System.Windows.Forms.TabPage();
         this.label14 = new System.Windows.Forms.Label();
         this.txtLoadingRobotAddr = new System.Windows.Forms.TextBox();
         this.label15 = new System.Windows.Forms.Label();
         this.txtLoadingStationAddr = new System.Windows.Forms.TextBox();
         this.label16 = new System.Windows.Forms.Label();
         this.txtUnloadingRobotAddr = new System.Windows.Forms.TextBox();
         this.label17 = new System.Windows.Forms.Label();
         this.txtUnloadingStationAddr = new System.Windows.Forms.TextBox();
         this.label5 = new System.Windows.Forms.Label();
         this.numPort = new System.Windows.Forms.NumericUpDown();
         this.label6 = new System.Windows.Forms.Label();
         this.numNetwork = new System.Windows.Forms.NumericUpDown();
         this.label7 = new System.Windows.Forms.Label();
         this.numTimeout = new System.Windows.Forms.NumericUpDown();
         this.label8 = new System.Windows.Forms.Label();
         this.numRetryCount = new System.Windows.Forms.NumericUpDown();
         this.label9 = new System.Windows.Forms.Label();
         this.numRetryBackoff = new System.Windows.Forms.NumericUpDown();
         this.label2 = new System.Windows.Forms.Label();
         this.numStation = new System.Windows.Forms.NumericUpDown();
         this.chkIsx64 = new System.Windows.Forms.CheckBox();
         this.label10 = new System.Windows.Forms.Label();
         this.cmbEndian = new System.Windows.Forms.ComboBox();
         this.tpMaintenance = new System.Windows.Forms.TabPage();
         this.paramAddrDeviceToPlcRequestPosData = new GRT.SDK.Framework.Component.ParamTextUserControl();
         this.paramAddrDeviceToPlcRequestTrackingData = new GRT.SDK.Framework.Component.ParamTextUserControl();
         this.paramAddrDeviceToPlcRequestFlag = new GRT.SDK.Framework.Component.ParamTextUserControl();
         this.paramAddrPlcToDeviceResponseNg = new GRT.SDK.Framework.Component.ParamTextUserControl();
         this.paramAddrPlcToDeviceResponseOk = new GRT.SDK.Framework.Component.ParamTextUserControl();
         this.paramAddrPlcToDeviceRequestPosData = new GRT.SDK.Framework.Component.ParamTextUserControl();
         this.paramAddrDeviceToPlcResponseFlag = new GRT.SDK.Framework.Component.ParamTextUserControl();
         this.paramAddrPlcToDeviceRequestTrackingData = new GRT.SDK.Framework.Component.ParamTextUserControl();
         this.paramAddrPlcToDeviceRequestFlag = new GRT.SDK.Framework.Component.ParamTextUserControl();
         this.paramAddrPositionDataBase = new GRT.SDK.Framework.Component.ParamTextUserControl();
         this.paramEqToMplcT2Timeout = new GRT.SDK.Framework.Component.ParamNumericUpDownUserControl();
         this.paramEqToMplcT1Timeout = new GRT.SDK.Framework.Component.ParamNumericUpDownUserControl();
         this.paramMplcToEqT2Timeout = new GRT.SDK.Framework.Component.ParamNumericUpDownUserControl();
         this.paramMplcToEqT1Timeout = new GRT.SDK.Framework.Component.ParamNumericUpDownUserControl();
         this.tpMoveOut = new System.Windows.Forms.TabPage();
         this.paramMoveOutT2Timeout = new GRT.SDK.Framework.Component.ParamNumericUpDownUserControl();
         this.paramMoveOutT1Timeout = new GRT.SDK.Framework.Component.ParamNumericUpDownUserControl();
         this.tpRegularReport = new System.Windows.Forms.TabPage();
         this.paramRegularReportInterval = new GRT.SDK.Framework.Component.ParamNumericUpDownUserControl();
         this.tpRecipe = new System.Windows.Forms.TabPage();
         this.paramRecipeRequestFlagAddress = new GRT.SDK.Framework.Component.ParamTextUserControl();
         this.paramRecipeRequestDataAddress = new GRT.SDK.Framework.Component.ParamTextUserControl();
         this.paramRecipeRequestRecipeNoAddress = new GRT.SDK.Framework.Component.ParamTextUserControl();
         this.paramRecipeResponseOkAddress = new GRT.SDK.Framework.Component.ParamTextUserControl();
         this.paramTextUserControl1 = new GRT.SDK.Framework.Component.ParamTextUserControl();
         this.paramRecipeResponseRecipeNoAddress = new GRT.SDK.Framework.Component.ParamTextUserControl();
         this.paramRecipeResponseThicknessAddress = new GRT.SDK.Framework.Component.ParamTextUserControl();
         this.paramRecipeResponseNgAddress = new GRT.SDK.Framework.Component.ParamTextUserControl();
         this.paramRecipeT1Timeout = new GRT.SDK.Framework.Component.ParamNumericUpDownUserControl();
         this.tabControl1.SuspendLayout();
         this.tabGeneral.SuspendLayout();
         this.tabApp.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.numTimeSync)).BeginInit();
         this.tabTracking.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.numPort)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.numNetwork)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.numTimeout)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.numRetryCount)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.numRetryBackoff)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.numStation)).BeginInit();
         this.tpMaintenance.SuspendLayout();
         this.tpMoveOut.SuspendLayout();
         this.tpRegularReport.SuspendLayout();
         this.tpRecipe.SuspendLayout();
         this.SuspendLayout();
         // 
         // tabControl1
         // 
         this.tabControl1.Controls.Add(this.tabApp);
         this.tabControl1.Controls.Add(this.tabTracking);
         this.tabControl1.Controls.Add(this.tpMaintenance);
         this.tabControl1.Controls.Add(this.tpMoveOut);
         this.tabControl1.Controls.Add(this.tpRegularReport);
         this.tabControl1.Controls.Add(this.tpRecipe);
         this.tabControl1.Location = new System.Drawing.Point(14, 15);
         this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
         this.tabControl1.Size = new System.Drawing.Size(732, 525);
         this.tabControl1.Controls.SetChildIndex(this.tpRecipe, 0);
         this.tabControl1.Controls.SetChildIndex(this.tpRegularReport, 0);
         this.tabControl1.Controls.SetChildIndex(this.tpMoveOut, 0);
         this.tabControl1.Controls.SetChildIndex(this.tpMaintenance, 0);
         this.tabControl1.Controls.SetChildIndex(this.tabTracking, 0);
         this.tabControl1.Controls.SetChildIndex(this.tabApp, 0);
         this.tabControl1.Controls.SetChildIndex(this.tabGeneral, 0);
         // 
         // tabGeneral
         // 
         this.tabGeneral.Controls.Add(this.label5);
         this.tabGeneral.Controls.Add(this.numPort);
         this.tabGeneral.Controls.Add(this.label6);
         this.tabGeneral.Controls.Add(this.numNetwork);
         this.tabGeneral.Controls.Add(this.label7);
         this.tabGeneral.Controls.Add(this.numTimeout);
         this.tabGeneral.Controls.Add(this.label8);
         this.tabGeneral.Controls.Add(this.numRetryCount);
         this.tabGeneral.Controls.Add(this.label9);
         this.tabGeneral.Controls.Add(this.numRetryBackoff);
         this.tabGeneral.Controls.Add(this.label2);
         this.tabGeneral.Controls.Add(this.numStation);
         this.tabGeneral.Controls.Add(this.chkIsx64);
         this.tabGeneral.Controls.Add(this.label10);
         this.tabGeneral.Controls.Add(this.cmbEndian);
         this.tabGeneral.Location = new System.Drawing.Point(4, 24);
         this.tabGeneral.Margin = new System.Windows.Forms.Padding(4);
         this.tabGeneral.Padding = new System.Windows.Forms.Padding(4);
         this.tabGeneral.Size = new System.Drawing.Size(724, 497);
         this.tabGeneral.Controls.SetChildIndex(this.cmbEndian, 0);
         this.tabGeneral.Controls.SetChildIndex(this.label10, 0);
         this.tabGeneral.Controls.SetChildIndex(this.chkIsx64, 0);
         this.tabGeneral.Controls.SetChildIndex(this.numStation, 0);
         this.tabGeneral.Controls.SetChildIndex(this.label2, 0);
         this.tabGeneral.Controls.SetChildIndex(this.numRetryBackoff, 0);
         this.tabGeneral.Controls.SetChildIndex(this.label9, 0);
         this.tabGeneral.Controls.SetChildIndex(this.numRetryCount, 0);
         this.tabGeneral.Controls.SetChildIndex(this.label8, 0);
         this.tabGeneral.Controls.SetChildIndex(this.numTimeout, 0);
         this.tabGeneral.Controls.SetChildIndex(this.label7, 0);
         this.tabGeneral.Controls.SetChildIndex(this.numNetwork, 0);
         this.tabGeneral.Controls.SetChildIndex(this.label6, 0);
         this.tabGeneral.Controls.SetChildIndex(this.numPort, 0);
         this.tabGeneral.Controls.SetChildIndex(this.label5, 0);
         this.tabGeneral.Controls.SetChildIndex(this.label4, 0);
         // 
         // label4
         // 
         this.label4.Location = new System.Drawing.Point(12, 181);
         this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.label4.Size = new System.Drawing.Size(120, 15);
         // 
         // btnSave
         // 
         this.btnSave.Location = new System.Drawing.Point(358, 558);
         this.btnSave.Margin = new System.Windows.Forms.Padding(4);
         this.btnSave.Size = new System.Drawing.Size(88, 31);
         // 
         // tabApp
         // 
         this.tabApp.Controls.Add(this.paramHeartbeatInterval);
         this.tabApp.Controls.Add(this.paramHeartbeatResponseAddress);
         this.tabApp.Controls.Add(this.paramHeartbeatRequestAddress);
         this.tabApp.Controls.Add(this.label11);
         this.tabApp.Controls.Add(this.numTimeSync);
         this.tabApp.Controls.Add(this.label12);
         this.tabApp.Controls.Add(this.txtTrigger);
         this.tabApp.Controls.Add(this.label13);
         this.tabApp.Controls.Add(this.txtData);
         this.tabApp.Location = new System.Drawing.Point(4, 24);
         this.tabApp.Margin = new System.Windows.Forms.Padding(4);
         this.tabApp.Name = "tabApp";
         this.tabApp.Padding = new System.Windows.Forms.Padding(4);
         this.tabApp.Size = new System.Drawing.Size(724, 497);
         this.tabApp.TabIndex = 1;
         this.tabApp.Text = "進階設定";
         this.tabApp.UseVisualStyleBackColor = true;
         // 
         // paramHeartbeatInterval
         // 
         this.paramHeartbeatInterval.Caption = "Heartbeat Inteval(ms)";
         this.paramHeartbeatInterval.CaptionWidth = 80F;
         this.paramHeartbeatInterval.DecimalPlaces = 0;
         this.paramHeartbeatInterval.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
         this.paramHeartbeatInterval.Increment = 1D;
         this.paramHeartbeatInterval.Location = new System.Drawing.Point(15, 267);
         this.paramHeartbeatInterval.MaxNumber = 1000D;
         this.paramHeartbeatInterval.MinimumSize = new System.Drawing.Size(150, 28);
         this.paramHeartbeatInterval.MinNumber = 0D;
         this.paramHeartbeatInterval.Name = "paramHeartbeatInterval";
         this.paramHeartbeatInterval.Size = new System.Drawing.Size(300, 28);
         this.paramHeartbeatInterval.TabIndex = 12;
         this.paramHeartbeatInterval.Value = 300D;
         // 
         // paramHeartbeatResponseAddress
         // 
         this.paramHeartbeatResponseAddress.Caption = "Heartbeat Response Address";
         this.paramHeartbeatResponseAddress.CaptionWidth = 80F;
         this.paramHeartbeatResponseAddress.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
         this.paramHeartbeatResponseAddress.Location = new System.Drawing.Point(15, 233);
         this.paramHeartbeatResponseAddress.MinimumSize = new System.Drawing.Size(150, 28);
         this.paramHeartbeatResponseAddress.Name = "paramHeartbeatResponseAddress";
         this.paramHeartbeatResponseAddress.ReadOnly = false;
         this.paramHeartbeatResponseAddress.ShowKeyboard = false;
         this.paramHeartbeatResponseAddress.Size = new System.Drawing.Size(300, 28);
         this.paramHeartbeatResponseAddress.TabIndex = 11;
         this.paramHeartbeatResponseAddress.TextValue = "";
         // 
         // paramHeartbeatRequestAddress
         // 
         this.paramHeartbeatRequestAddress.Caption = "Heartbeat Request Address";
         this.paramHeartbeatRequestAddress.CaptionWidth = 80F;
         this.paramHeartbeatRequestAddress.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
         this.paramHeartbeatRequestAddress.Location = new System.Drawing.Point(15, 200);
         this.paramHeartbeatRequestAddress.MinimumSize = new System.Drawing.Size(150, 28);
         this.paramHeartbeatRequestAddress.Name = "paramHeartbeatRequestAddress";
         this.paramHeartbeatRequestAddress.ReadOnly = false;
         this.paramHeartbeatRequestAddress.ShowKeyboard = false;
         this.paramHeartbeatRequestAddress.Size = new System.Drawing.Size(300, 28);
         this.paramHeartbeatRequestAddress.TabIndex = 10;
         this.paramHeartbeatRequestAddress.TextValue = "";
         // 
         // label11
         // 
         this.label11.AutoSize = true;
         this.label11.Location = new System.Drawing.Point(12, 59);
         this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.label11.Name = "label11";
         this.label11.Size = new System.Drawing.Size(73, 15);
         this.label11.TabIndex = 2;
         this.label11.Text = "TS Int (ms):";
         // 
         // numTimeSync
         // 
         this.numTimeSync.Location = new System.Drawing.Point(117, 56);
         this.numTimeSync.Margin = new System.Windows.Forms.Padding(4);
         this.numTimeSync.Maximum = new decimal(new int[] {
            3600000,
            0,
            0,
            0});
         this.numTimeSync.Name = "numTimeSync";
         this.numTimeSync.Size = new System.Drawing.Size(93, 22);
         this.numTimeSync.TabIndex = 3;
         this.numTimeSync.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
         // 
         // label12
         // 
         this.label12.AutoSize = true;
         this.label12.Location = new System.Drawing.Point(12, 97);
         this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.label12.Name = "label12";
         this.label12.Size = new System.Drawing.Size(70, 15);
         this.label12.TabIndex = 4;
         this.label12.Text = "TS Trigger:";
         // 
         // txtTrigger
         // 
         this.txtTrigger.Location = new System.Drawing.Point(117, 94);
         this.txtTrigger.Margin = new System.Windows.Forms.Padding(4);
         this.txtTrigger.Name = "txtTrigger";
         this.txtTrigger.Size = new System.Drawing.Size(93, 22);
         this.txtTrigger.TabIndex = 5;
         // 
         // label13
         // 
         this.label13.AutoSize = true;
         this.label13.Location = new System.Drawing.Point(12, 134);
         this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.label13.Name = "label13";
         this.label13.Size = new System.Drawing.Size(56, 15);
         this.label13.TabIndex = 6;
         this.label13.Text = "TS Data:";
         // 
         // txtData
         // 
         this.txtData.Location = new System.Drawing.Point(117, 131);
         this.txtData.Margin = new System.Windows.Forms.Padding(4);
         this.txtData.Name = "txtData";
         this.txtData.Size = new System.Drawing.Size(93, 22);
         this.txtData.TabIndex = 7;
         // 
         // tabTracking
         // 
         this.tabTracking.Controls.Add(this.label14);
         this.tabTracking.Controls.Add(this.txtLoadingRobotAddr);
         this.tabTracking.Controls.Add(this.label15);
         this.tabTracking.Controls.Add(this.txtLoadingStationAddr);
         this.tabTracking.Controls.Add(this.label16);
         this.tabTracking.Controls.Add(this.txtUnloadingRobotAddr);
         this.tabTracking.Controls.Add(this.label17);
         this.tabTracking.Controls.Add(this.txtUnloadingStationAddr);
         this.tabTracking.Location = new System.Drawing.Point(4, 24);
         this.tabTracking.Margin = new System.Windows.Forms.Padding(4);
         this.tabTracking.Name = "tabTracking";
         this.tabTracking.Padding = new System.Windows.Forms.Padding(4);
         this.tabTracking.Size = new System.Drawing.Size(724, 497);
         this.tabTracking.TabIndex = 2;
         this.tabTracking.Text = "追蹤設定";
         this.tabTracking.UseVisualStyleBackColor = true;
         // 
         // label14
         // 
         this.label14.AutoSize = true;
         this.label14.Location = new System.Drawing.Point(12, 22);
         this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.label14.Name = "label14";
         this.label14.Size = new System.Drawing.Size(91, 15);
         this.label14.TabIndex = 0;
         this.label14.Text = "插框Robot位址:";
         // 
         // txtLoadingRobotAddr
         // 
         this.txtLoadingRobotAddr.Location = new System.Drawing.Point(140, 19);
         this.txtLoadingRobotAddr.Margin = new System.Windows.Forms.Padding(4);
         this.txtLoadingRobotAddr.Name = "txtLoadingRobotAddr";
         this.txtLoadingRobotAddr.Size = new System.Drawing.Size(116, 22);
         this.txtLoadingRobotAddr.TabIndex = 1;
         // 
         // label15
         // 
         this.label15.AutoSize = true;
         this.label15.Location = new System.Drawing.Point(12, 59);
         this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.label15.Name = "label15";
         this.label15.Size = new System.Drawing.Size(70, 15);
         this.label15.TabIndex = 2;
         this.label15.Text = "插框站位址:";
         // 
         // txtLoadingStationAddr
         // 
         this.txtLoadingStationAddr.Location = new System.Drawing.Point(140, 56);
         this.txtLoadingStationAddr.Margin = new System.Windows.Forms.Padding(4);
         this.txtLoadingStationAddr.Name = "txtLoadingStationAddr";
         this.txtLoadingStationAddr.Size = new System.Drawing.Size(116, 22);
         this.txtLoadingStationAddr.TabIndex = 3;
         // 
         // label16
         // 
         this.label16.AutoSize = true;
         this.label16.Location = new System.Drawing.Point(12, 97);
         this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.label16.Name = "label16";
         this.label16.Size = new System.Drawing.Size(91, 15);
         this.label16.TabIndex = 4;
         this.label16.Text = "拆框Robot位址:";
         // 
         // txtUnloadingRobotAddr
         // 
         this.txtUnloadingRobotAddr.Location = new System.Drawing.Point(140, 94);
         this.txtUnloadingRobotAddr.Margin = new System.Windows.Forms.Padding(4);
         this.txtUnloadingRobotAddr.Name = "txtUnloadingRobotAddr";
         this.txtUnloadingRobotAddr.Size = new System.Drawing.Size(116, 22);
         this.txtUnloadingRobotAddr.TabIndex = 5;
         // 
         // label17
         // 
         this.label17.AutoSize = true;
         this.label17.Location = new System.Drawing.Point(12, 134);
         this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.label17.Name = "label17";
         this.label17.Size = new System.Drawing.Size(70, 15);
         this.label17.TabIndex = 6;
         this.label17.Text = "拆框站位址:";
         // 
         // txtUnloadingStationAddr
         // 
         this.txtUnloadingStationAddr.Location = new System.Drawing.Point(140, 131);
         this.txtUnloadingStationAddr.Margin = new System.Windows.Forms.Padding(4);
         this.txtUnloadingStationAddr.Name = "txtUnloadingStationAddr";
         this.txtUnloadingStationAddr.Size = new System.Drawing.Size(116, 22);
         this.txtUnloadingStationAddr.TabIndex = 7;
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Location = new System.Drawing.Point(12, 22);
         this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(34, 15);
         this.label5.TabIndex = 0;
         this.label5.Text = "Port:";
         // 
         // numPort
         // 
         this.numPort.Location = new System.Drawing.Point(82, 19);
         this.numPort.Margin = new System.Windows.Forms.Padding(4);
         this.numPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
         this.numPort.Name = "numPort";
         this.numPort.Size = new System.Drawing.Size(93, 22);
         this.numPort.TabIndex = 1;
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Location = new System.Drawing.Point(12, 56);
         this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(59, 15);
         this.label6.TabIndex = 2;
         this.label6.Text = "Network:";
         // 
         // numNetwork
         // 
         this.numNetwork.Location = new System.Drawing.Point(82, 53);
         this.numNetwork.Margin = new System.Windows.Forms.Padding(4);
         this.numNetwork.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
         this.numNetwork.Name = "numNetwork";
         this.numNetwork.Size = new System.Drawing.Size(70, 22);
         this.numNetwork.TabIndex = 3;
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.Location = new System.Drawing.Point(210, 22);
         this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(87, 15);
         this.label7.TabIndex = 4;
         this.label7.Text = "Timeout (ms):";
         // 
         // numTimeout
         // 
         this.numTimeout.Location = new System.Drawing.Point(303, 19);
         this.numTimeout.Margin = new System.Windows.Forms.Padding(4);
         this.numTimeout.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
         this.numTimeout.Name = "numTimeout";
         this.numTimeout.Size = new System.Drawing.Size(93, 22);
         this.numTimeout.TabIndex = 5;
         this.numTimeout.Value = new decimal(new int[] {
            3000,
            0,
            0,
            0});
         // 
         // label8
         // 
         this.label8.AutoSize = true;
         this.label8.Location = new System.Drawing.Point(210, 56);
         this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.label8.Name = "label8";
         this.label8.Size = new System.Drawing.Size(78, 15);
         this.label8.TabIndex = 6;
         this.label8.Text = "Retry Count:";
         // 
         // numRetryCount
         // 
         this.numRetryCount.Location = new System.Drawing.Point(303, 53);
         this.numRetryCount.Margin = new System.Windows.Forms.Padding(4);
         this.numRetryCount.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
         this.numRetryCount.Name = "numRetryCount";
         this.numRetryCount.Size = new System.Drawing.Size(70, 22);
         this.numRetryCount.TabIndex = 7;
         this.numRetryCount.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
         // 
         // label9
         // 
         this.label9.AutoSize = true;
         this.label9.Location = new System.Drawing.Point(210, 91);
         this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.label9.Name = "label9";
         this.label9.Size = new System.Drawing.Size(88, 15);
         this.label9.TabIndex = 8;
         this.label9.Text = "Retry Backoff:";
         // 
         // numRetryBackoff
         // 
         this.numRetryBackoff.Location = new System.Drawing.Point(303, 89);
         this.numRetryBackoff.Margin = new System.Windows.Forms.Padding(4);
         this.numRetryBackoff.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
         this.numRetryBackoff.Name = "numRetryBackoff";
         this.numRetryBackoff.Size = new System.Drawing.Size(93, 22);
         this.numRetryBackoff.TabIndex = 9;
         this.numRetryBackoff.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(12, 127);
         this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(50, 15);
         this.label2.TabIndex = 10;
         this.label2.Text = "Station:";
         // 
         // numStation
         // 
         this.numStation.Location = new System.Drawing.Point(82, 124);
         this.numStation.Margin = new System.Windows.Forms.Padding(4);
         this.numStation.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
         this.numStation.Name = "numStation";
         this.numStation.Size = new System.Drawing.Size(70, 22);
         this.numStation.TabIndex = 11;
         // 
         // chkIsx64
         // 
         this.chkIsx64.AutoSize = true;
         this.chkIsx64.Location = new System.Drawing.Point(212, 127);
         this.chkIsx64.Margin = new System.Windows.Forms.Padding(4);
         this.chkIsx64.Name = "chkIsx64";
         this.chkIsx64.Size = new System.Drawing.Size(80, 19);
         this.chkIsx64.TabIndex = 12;
         this.chkIsx64.Text = "Is 64-bit?";
         this.chkIsx64.UseVisualStyleBackColor = true;
         // 
         // label10
         // 
         this.label10.AutoSize = true;
         this.label10.Location = new System.Drawing.Point(12, 161);
         this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.label10.Name = "label10";
         this.label10.Size = new System.Drawing.Size(48, 15);
         this.label10.TabIndex = 13;
         this.label10.Text = "Endian:";
         // 
         // cmbEndian
         // 
         this.cmbEndian.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cmbEndian.FormattingEnabled = true;
         this.cmbEndian.Items.AddRange(new object[] {
            "Big",
            "Little"});
         this.cmbEndian.Location = new System.Drawing.Point(82, 158);
         this.cmbEndian.Margin = new System.Windows.Forms.Padding(4);
         this.cmbEndian.Name = "cmbEndian";
         this.cmbEndian.Size = new System.Drawing.Size(93, 23);
         this.cmbEndian.TabIndex = 14;
         // 
         // tpMaintenance
         // 
         this.tpMaintenance.Controls.Add(this.paramAddrDeviceToPlcRequestPosData);
         this.tpMaintenance.Controls.Add(this.paramAddrDeviceToPlcRequestTrackingData);
         this.tpMaintenance.Controls.Add(this.paramAddrDeviceToPlcRequestFlag);
         this.tpMaintenance.Controls.Add(this.paramAddrPlcToDeviceResponseNg);
         this.tpMaintenance.Controls.Add(this.paramAddrPlcToDeviceResponseOk);
         this.tpMaintenance.Controls.Add(this.paramAddrPlcToDeviceRequestPosData);
         this.tpMaintenance.Controls.Add(this.paramAddrDeviceToPlcResponseFlag);
         this.tpMaintenance.Controls.Add(this.paramAddrPlcToDeviceRequestTrackingData);
         this.tpMaintenance.Controls.Add(this.paramAddrPlcToDeviceRequestFlag);
         this.tpMaintenance.Controls.Add(this.paramAddrPositionDataBase);
         this.tpMaintenance.Controls.Add(this.paramEqToMplcT2Timeout);
         this.tpMaintenance.Controls.Add(this.paramEqToMplcT1Timeout);
         this.tpMaintenance.Controls.Add(this.paramMplcToEqT2Timeout);
         this.tpMaintenance.Controls.Add(this.paramMplcToEqT1Timeout);
         this.tpMaintenance.Location = new System.Drawing.Point(4, 24);
         this.tpMaintenance.Name = "tpMaintenance";
         this.tpMaintenance.Padding = new System.Windows.Forms.Padding(3);
         this.tpMaintenance.Size = new System.Drawing.Size(724, 497);
         this.tpMaintenance.TabIndex = 3;
         this.tpMaintenance.Text = "維護設定";
         this.tpMaintenance.UseVisualStyleBackColor = true;
         // 
         // paramAddrDeviceToPlcRequestPosData
         // 
         this.paramAddrDeviceToPlcRequestPosData.Caption = "Device To PLC Request Pos Data Address";
         this.paramAddrDeviceToPlcRequestPosData.CaptionWidth = 80F;
         this.paramAddrDeviceToPlcRequestPosData.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
         this.paramAddrDeviceToPlcRequestPosData.Location = new System.Drawing.Point(370, 155);
         this.paramAddrDeviceToPlcRequestPosData.MinimumSize = new System.Drawing.Size(150, 28);
         this.paramAddrDeviceToPlcRequestPosData.Name = "paramAddrDeviceToPlcRequestPosData";
         this.paramAddrDeviceToPlcRequestPosData.ReadOnly = false;
         this.paramAddrDeviceToPlcRequestPosData.ShowKeyboard = false;
         this.paramAddrDeviceToPlcRequestPosData.Size = new System.Drawing.Size(339, 28);
         this.paramAddrDeviceToPlcRequestPosData.TabIndex = 28;
         this.paramAddrDeviceToPlcRequestPosData.TextValue = "";
         // 
         // paramAddrDeviceToPlcRequestTrackingData
         // 
         this.paramAddrDeviceToPlcRequestTrackingData.Caption = "Device To PLC Request Tracking Data";
         this.paramAddrDeviceToPlcRequestTrackingData.CaptionWidth = 80F;
         this.paramAddrDeviceToPlcRequestTrackingData.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
         this.paramAddrDeviceToPlcRequestTrackingData.Location = new System.Drawing.Point(370, 121);
         this.paramAddrDeviceToPlcRequestTrackingData.MinimumSize = new System.Drawing.Size(150, 28);
         this.paramAddrDeviceToPlcRequestTrackingData.Name = "paramAddrDeviceToPlcRequestTrackingData";
         this.paramAddrDeviceToPlcRequestTrackingData.ReadOnly = false;
         this.paramAddrDeviceToPlcRequestTrackingData.ShowKeyboard = false;
         this.paramAddrDeviceToPlcRequestTrackingData.Size = new System.Drawing.Size(339, 28);
         this.paramAddrDeviceToPlcRequestTrackingData.TabIndex = 27;
         this.paramAddrDeviceToPlcRequestTrackingData.TextValue = "";
         // 
         // paramAddrDeviceToPlcRequestFlag
         // 
         this.paramAddrDeviceToPlcRequestFlag.Caption = "Device To PLC Request Flag Address";
         this.paramAddrDeviceToPlcRequestFlag.CaptionWidth = 80F;
         this.paramAddrDeviceToPlcRequestFlag.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
         this.paramAddrDeviceToPlcRequestFlag.Location = new System.Drawing.Point(370, 87);
         this.paramAddrDeviceToPlcRequestFlag.MinimumSize = new System.Drawing.Size(150, 28);
         this.paramAddrDeviceToPlcRequestFlag.Name = "paramAddrDeviceToPlcRequestFlag";
         this.paramAddrDeviceToPlcRequestFlag.ReadOnly = false;
         this.paramAddrDeviceToPlcRequestFlag.ShowKeyboard = false;
         this.paramAddrDeviceToPlcRequestFlag.Size = new System.Drawing.Size(339, 28);
         this.paramAddrDeviceToPlcRequestFlag.TabIndex = 26;
         this.paramAddrDeviceToPlcRequestFlag.TextValue = "";
         // 
         // paramAddrPlcToDeviceResponseNg
         // 
         this.paramAddrPlcToDeviceResponseNg.Caption = "PLC To Device Response NG Address";
         this.paramAddrPlcToDeviceResponseNg.CaptionWidth = 80F;
         this.paramAddrPlcToDeviceResponseNg.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
         this.paramAddrPlcToDeviceResponseNg.Location = new System.Drawing.Point(16, 256);
         this.paramAddrPlcToDeviceResponseNg.MinimumSize = new System.Drawing.Size(150, 28);
         this.paramAddrPlcToDeviceResponseNg.Name = "paramAddrPlcToDeviceResponseNg";
         this.paramAddrPlcToDeviceResponseNg.ReadOnly = false;
         this.paramAddrPlcToDeviceResponseNg.ShowKeyboard = false;
         this.paramAddrPlcToDeviceResponseNg.Size = new System.Drawing.Size(339, 28);
         this.paramAddrPlcToDeviceResponseNg.TabIndex = 25;
         this.paramAddrPlcToDeviceResponseNg.TextValue = "";
         // 
         // paramAddrPlcToDeviceResponseOk
         // 
         this.paramAddrPlcToDeviceResponseOk.Caption = "PLC To Device Response OK Address";
         this.paramAddrPlcToDeviceResponseOk.CaptionWidth = 80F;
         this.paramAddrPlcToDeviceResponseOk.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
         this.paramAddrPlcToDeviceResponseOk.Location = new System.Drawing.Point(16, 222);
         this.paramAddrPlcToDeviceResponseOk.MinimumSize = new System.Drawing.Size(150, 28);
         this.paramAddrPlcToDeviceResponseOk.Name = "paramAddrPlcToDeviceResponseOk";
         this.paramAddrPlcToDeviceResponseOk.ReadOnly = false;
         this.paramAddrPlcToDeviceResponseOk.ShowKeyboard = false;
         this.paramAddrPlcToDeviceResponseOk.Size = new System.Drawing.Size(339, 28);
         this.paramAddrPlcToDeviceResponseOk.TabIndex = 24;
         this.paramAddrPlcToDeviceResponseOk.TextValue = "";
         // 
         // paramAddrPlcToDeviceRequestPosData
         // 
         this.paramAddrPlcToDeviceRequestPosData.Caption = "PLC To Device Request Pos Data Address";
         this.paramAddrPlcToDeviceRequestPosData.CaptionWidth = 80F;
         this.paramAddrPlcToDeviceRequestPosData.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
         this.paramAddrPlcToDeviceRequestPosData.Location = new System.Drawing.Point(16, 188);
         this.paramAddrPlcToDeviceRequestPosData.MinimumSize = new System.Drawing.Size(150, 28);
         this.paramAddrPlcToDeviceRequestPosData.Name = "paramAddrPlcToDeviceRequestPosData";
         this.paramAddrPlcToDeviceRequestPosData.ReadOnly = false;
         this.paramAddrPlcToDeviceRequestPosData.ShowKeyboard = false;
         this.paramAddrPlcToDeviceRequestPosData.Size = new System.Drawing.Size(339, 28);
         this.paramAddrPlcToDeviceRequestPosData.TabIndex = 23;
         this.paramAddrPlcToDeviceRequestPosData.TextValue = "";
         // 
         // paramAddrDeviceToPlcResponseFlag
         // 
         this.paramAddrDeviceToPlcResponseFlag.Caption = "Device To PLC Response Flag Address";
         this.paramAddrDeviceToPlcResponseFlag.CaptionWidth = 80F;
         this.paramAddrDeviceToPlcResponseFlag.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
         this.paramAddrDeviceToPlcResponseFlag.Location = new System.Drawing.Point(370, 188);
         this.paramAddrDeviceToPlcResponseFlag.MinimumSize = new System.Drawing.Size(150, 28);
         this.paramAddrDeviceToPlcResponseFlag.Name = "paramAddrDeviceToPlcResponseFlag";
         this.paramAddrDeviceToPlcResponseFlag.ReadOnly = false;
         this.paramAddrDeviceToPlcResponseFlag.ShowKeyboard = false;
         this.paramAddrDeviceToPlcResponseFlag.Size = new System.Drawing.Size(339, 28);
         this.paramAddrDeviceToPlcResponseFlag.TabIndex = 22;
         this.paramAddrDeviceToPlcResponseFlag.TextValue = "";
         // 
         // paramAddrPlcToDeviceRequestTrackingData
         // 
         this.paramAddrPlcToDeviceRequestTrackingData.Caption = "PLC To Device Request Tracking Data Address";
         this.paramAddrPlcToDeviceRequestTrackingData.CaptionWidth = 80F;
         this.paramAddrPlcToDeviceRequestTrackingData.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
         this.paramAddrPlcToDeviceRequestTrackingData.Location = new System.Drawing.Point(16, 155);
         this.paramAddrPlcToDeviceRequestTrackingData.MinimumSize = new System.Drawing.Size(150, 28);
         this.paramAddrPlcToDeviceRequestTrackingData.Name = "paramAddrPlcToDeviceRequestTrackingData";
         this.paramAddrPlcToDeviceRequestTrackingData.ReadOnly = false;
         this.paramAddrPlcToDeviceRequestTrackingData.ShowKeyboard = false;
         this.paramAddrPlcToDeviceRequestTrackingData.Size = new System.Drawing.Size(339, 28);
         this.paramAddrPlcToDeviceRequestTrackingData.TabIndex = 21;
         this.paramAddrPlcToDeviceRequestTrackingData.TextValue = "";
         // 
         // paramAddrPlcToDeviceRequestFlag
         // 
         this.paramAddrPlcToDeviceRequestFlag.Caption = "PLC To Device Request Flag Address";
         this.paramAddrPlcToDeviceRequestFlag.CaptionWidth = 80F;
         this.paramAddrPlcToDeviceRequestFlag.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
         this.paramAddrPlcToDeviceRequestFlag.Location = new System.Drawing.Point(16, 121);
         this.paramAddrPlcToDeviceRequestFlag.MinimumSize = new System.Drawing.Size(150, 28);
         this.paramAddrPlcToDeviceRequestFlag.Name = "paramAddrPlcToDeviceRequestFlag";
         this.paramAddrPlcToDeviceRequestFlag.ReadOnly = false;
         this.paramAddrPlcToDeviceRequestFlag.ShowKeyboard = false;
         this.paramAddrPlcToDeviceRequestFlag.Size = new System.Drawing.Size(339, 28);
         this.paramAddrPlcToDeviceRequestFlag.TabIndex = 20;
         this.paramAddrPlcToDeviceRequestFlag.TextValue = "";
         // 
         // paramAddrPositionDataBase
         // 
         this.paramAddrPositionDataBase.Caption = "Position Data Base Address";
         this.paramAddrPositionDataBase.CaptionWidth = 80F;
         this.paramAddrPositionDataBase.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
         this.paramAddrPositionDataBase.Location = new System.Drawing.Point(16, 87);
         this.paramAddrPositionDataBase.MinimumSize = new System.Drawing.Size(150, 28);
         this.paramAddrPositionDataBase.Name = "paramAddrPositionDataBase";
         this.paramAddrPositionDataBase.ReadOnly = false;
         this.paramAddrPositionDataBase.ShowKeyboard = false;
         this.paramAddrPositionDataBase.Size = new System.Drawing.Size(339, 28);
         this.paramAddrPositionDataBase.TabIndex = 19;
         this.paramAddrPositionDataBase.TextValue = "";
         // 
         // paramEqToMplcT2Timeout
         // 
         this.paramEqToMplcT2Timeout.Caption = "PLC To Device T2 Timeout(ms)";
         this.paramEqToMplcT2Timeout.CaptionWidth = 80F;
         this.paramEqToMplcT2Timeout.DecimalPlaces = 0;
         this.paramEqToMplcT2Timeout.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
         this.paramEqToMplcT2Timeout.Increment = 100D;
         this.paramEqToMplcT2Timeout.Location = new System.Drawing.Point(370, 53);
         this.paramEqToMplcT2Timeout.MaxNumber = 99000D;
         this.paramEqToMplcT2Timeout.MinimumSize = new System.Drawing.Size(150, 28);
         this.paramEqToMplcT2Timeout.MinNumber = 0D;
         this.paramEqToMplcT2Timeout.Name = "paramEqToMplcT2Timeout";
         this.paramEqToMplcT2Timeout.Size = new System.Drawing.Size(339, 28);
         this.paramEqToMplcT2Timeout.TabIndex = 18;
         this.paramEqToMplcT2Timeout.Value = 1000D;
         // 
         // paramEqToMplcT1Timeout
         // 
         this.paramEqToMplcT1Timeout.Caption = "Device To PLC T1 Timeout(ms)";
         this.paramEqToMplcT1Timeout.CaptionWidth = 80F;
         this.paramEqToMplcT1Timeout.DecimalPlaces = 0;
         this.paramEqToMplcT1Timeout.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
         this.paramEqToMplcT1Timeout.Increment = 100D;
         this.paramEqToMplcT1Timeout.Location = new System.Drawing.Point(370, 20);
         this.paramEqToMplcT1Timeout.MaxNumber = 99000D;
         this.paramEqToMplcT1Timeout.MinimumSize = new System.Drawing.Size(150, 28);
         this.paramEqToMplcT1Timeout.MinNumber = 0D;
         this.paramEqToMplcT1Timeout.Name = "paramEqToMplcT1Timeout";
         this.paramEqToMplcT1Timeout.Size = new System.Drawing.Size(339, 28);
         this.paramEqToMplcT1Timeout.TabIndex = 17;
         this.paramEqToMplcT1Timeout.Value = 1000D;
         // 
         // paramMplcToEqT2Timeout
         // 
         this.paramMplcToEqT2Timeout.Caption = "PLC To Device T2 Timeout(ms)";
         this.paramMplcToEqT2Timeout.CaptionWidth = 80F;
         this.paramMplcToEqT2Timeout.DecimalPlaces = 0;
         this.paramMplcToEqT2Timeout.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
         this.paramMplcToEqT2Timeout.Increment = 100D;
         this.paramMplcToEqT2Timeout.Location = new System.Drawing.Point(16, 53);
         this.paramMplcToEqT2Timeout.MaxNumber = 99000D;
         this.paramMplcToEqT2Timeout.MinimumSize = new System.Drawing.Size(150, 28);
         this.paramMplcToEqT2Timeout.MinNumber = 0D;
         this.paramMplcToEqT2Timeout.Name = "paramMplcToEqT2Timeout";
         this.paramMplcToEqT2Timeout.Size = new System.Drawing.Size(339, 28);
         this.paramMplcToEqT2Timeout.TabIndex = 14;
         this.paramMplcToEqT2Timeout.Value = 1000D;
         // 
         // paramMplcToEqT1Timeout
         // 
         this.paramMplcToEqT1Timeout.Caption = "PLC To Device T1 Timeout(ms)";
         this.paramMplcToEqT1Timeout.CaptionWidth = 80F;
         this.paramMplcToEqT1Timeout.DecimalPlaces = 0;
         this.paramMplcToEqT1Timeout.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
         this.paramMplcToEqT1Timeout.Increment = 100D;
         this.paramMplcToEqT1Timeout.Location = new System.Drawing.Point(16, 20);
         this.paramMplcToEqT1Timeout.MaxNumber = 99000D;
         this.paramMplcToEqT1Timeout.MinimumSize = new System.Drawing.Size(150, 28);
         this.paramMplcToEqT1Timeout.MinNumber = 0D;
         this.paramMplcToEqT1Timeout.Name = "paramMplcToEqT1Timeout";
         this.paramMplcToEqT1Timeout.Size = new System.Drawing.Size(339, 28);
         this.paramMplcToEqT1Timeout.TabIndex = 13;
         this.paramMplcToEqT1Timeout.Value = 1000D;
         // 
         // tpMoveOut
         // 
         this.tpMoveOut.Controls.Add(this.paramMoveOutT2Timeout);
         this.tpMoveOut.Controls.Add(this.paramMoveOutT1Timeout);
         this.tpMoveOut.Font = new System.Drawing.Font("更紗黑體 UI TC", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
         this.tpMoveOut.Location = new System.Drawing.Point(4, 24);
         this.tpMoveOut.Name = "tpMoveOut";
         this.tpMoveOut.Padding = new System.Windows.Forms.Padding(3);
         this.tpMoveOut.Size = new System.Drawing.Size(724, 497);
         this.tpMoveOut.TabIndex = 4;
         this.tpMoveOut.Text = "Move Out";
         this.tpMoveOut.UseVisualStyleBackColor = true;
         // 
         // paramMoveOutT2Timeout
         // 
         this.paramMoveOutT2Timeout.Caption = "T2 Timeout(ms)";
         this.paramMoveOutT2Timeout.CaptionWidth = 70F;
         this.paramMoveOutT2Timeout.DecimalPlaces = 0;
         this.paramMoveOutT2Timeout.Font = new System.Drawing.Font("更紗黑體 UI TC", 9.749999F);
         this.paramMoveOutT2Timeout.Increment = 100D;
         this.paramMoveOutT2Timeout.Location = new System.Drawing.Point(20, 56);
         this.paramMoveOutT2Timeout.MaxNumber = 99000D;
         this.paramMoveOutT2Timeout.MinimumSize = new System.Drawing.Size(171, 30);
         this.paramMoveOutT2Timeout.MinNumber = 0D;
         this.paramMoveOutT2Timeout.Name = "paramMoveOutT2Timeout";
         this.paramMoveOutT2Timeout.Size = new System.Drawing.Size(227, 30);
         this.paramMoveOutT2Timeout.TabIndex = 16;
         this.paramMoveOutT2Timeout.Value = 1000D;
         // 
         // paramMoveOutT1Timeout
         // 
         this.paramMoveOutT1Timeout.Caption = "T1 Timeout(ms)";
         this.paramMoveOutT1Timeout.CaptionWidth = 70F;
         this.paramMoveOutT1Timeout.DecimalPlaces = 0;
         this.paramMoveOutT1Timeout.Font = new System.Drawing.Font("更紗黑體 UI TC", 9.749999F);
         this.paramMoveOutT1Timeout.Increment = 100D;
         this.paramMoveOutT1Timeout.Location = new System.Drawing.Point(20, 20);
         this.paramMoveOutT1Timeout.MaxNumber = 99000D;
         this.paramMoveOutT1Timeout.MinimumSize = new System.Drawing.Size(171, 30);
         this.paramMoveOutT1Timeout.MinNumber = 0D;
         this.paramMoveOutT1Timeout.Name = "paramMoveOutT1Timeout";
         this.paramMoveOutT1Timeout.Size = new System.Drawing.Size(227, 30);
         this.paramMoveOutT1Timeout.TabIndex = 15;
         this.paramMoveOutT1Timeout.Value = 1000D;
         // 
         // tpRegularReport
         // 
         this.tpRegularReport.Controls.Add(this.paramRegularReportInterval);
         this.tpRegularReport.Location = new System.Drawing.Point(4, 24);
         this.tpRegularReport.Name = "tpRegularReport";
         this.tpRegularReport.Padding = new System.Windows.Forms.Padding(3);
         this.tpRegularReport.Size = new System.Drawing.Size(724, 497);
         this.tpRegularReport.TabIndex = 5;
         this.tpRegularReport.Text = "Regular Report";
         this.tpRegularReport.UseVisualStyleBackColor = true;
         // 
         // paramRegularReportInterval
         // 
         this.paramRegularReportInterval.Caption = "Regular Report Interval(ms)";
         this.paramRegularReportInterval.CaptionWidth = 80F;
         this.paramRegularReportInterval.DecimalPlaces = 0;
         this.paramRegularReportInterval.Font = new System.Drawing.Font("更紗黑體 UI TC", 9.749999F);
         this.paramRegularReportInterval.Increment = 100D;
         this.paramRegularReportInterval.Location = new System.Drawing.Point(20, 20);
         this.paramRegularReportInterval.MaxNumber = 30000D;
         this.paramRegularReportInterval.MinimumSize = new System.Drawing.Size(171, 30);
         this.paramRegularReportInterval.MinNumber = 10000D;
         this.paramRegularReportInterval.Name = "paramRegularReportInterval";
         this.paramRegularReportInterval.Size = new System.Drawing.Size(314, 30);
         this.paramRegularReportInterval.TabIndex = 16;
         this.paramRegularReportInterval.Value = 10000D;
         // 
         // tpRecipe
         // 
         this.tpRecipe.Controls.Add(this.paramRecipeT1Timeout);
         this.tpRecipe.Controls.Add(this.paramTextUserControl1);
         this.tpRecipe.Controls.Add(this.paramRecipeResponseRecipeNoAddress);
         this.tpRecipe.Controls.Add(this.paramRecipeResponseThicknessAddress);
         this.tpRecipe.Controls.Add(this.paramRecipeResponseNgAddress);
         this.tpRecipe.Controls.Add(this.paramRecipeResponseOkAddress);
         this.tpRecipe.Controls.Add(this.paramRecipeRequestRecipeNoAddress);
         this.tpRecipe.Controls.Add(this.paramRecipeRequestDataAddress);
         this.tpRecipe.Controls.Add(this.paramRecipeRequestFlagAddress);
         this.tpRecipe.Location = new System.Drawing.Point(4, 24);
         this.tpRecipe.Name = "tpRecipe";
         this.tpRecipe.Padding = new System.Windows.Forms.Padding(3);
         this.tpRecipe.Size = new System.Drawing.Size(724, 497);
         this.tpRecipe.TabIndex = 6;
         this.tpRecipe.Text = "Recipe";
         this.tpRecipe.UseVisualStyleBackColor = true;
         // 
         // paramRecipeRequestFlagAddress
         // 
         this.paramRecipeRequestFlagAddress.Caption = "Recipe Request Flag Address";
         this.paramRecipeRequestFlagAddress.CaptionWidth = 80F;
         this.paramRecipeRequestFlagAddress.Font = new System.Drawing.Font("更紗黑體 UI TC", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
         this.paramRecipeRequestFlagAddress.Location = new System.Drawing.Point(8, 8);
         this.paramRecipeRequestFlagAddress.Margin = new System.Windows.Forms.Padding(5);
         this.paramRecipeRequestFlagAddress.MinimumSize = new System.Drawing.Size(150, 28);
         this.paramRecipeRequestFlagAddress.Name = "paramRecipeRequestFlagAddress";
         this.paramRecipeRequestFlagAddress.ReadOnly = false;
         this.paramRecipeRequestFlagAddress.ShowKeyboard = false;
         this.paramRecipeRequestFlagAddress.Size = new System.Drawing.Size(339, 28);
         this.paramRecipeRequestFlagAddress.TabIndex = 20;
         this.paramRecipeRequestFlagAddress.TextValue = "";
         // 
         // paramRecipeRequestDataAddress
         // 
         this.paramRecipeRequestDataAddress.Caption = "Recipe Request Data Address";
         this.paramRecipeRequestDataAddress.CaptionWidth = 80F;
         this.paramRecipeRequestDataAddress.Font = new System.Drawing.Font("更紗黑體 UI TC", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
         this.paramRecipeRequestDataAddress.Location = new System.Drawing.Point(8, 46);
         this.paramRecipeRequestDataAddress.Margin = new System.Windows.Forms.Padding(5);
         this.paramRecipeRequestDataAddress.MinimumSize = new System.Drawing.Size(150, 28);
         this.paramRecipeRequestDataAddress.Name = "paramRecipeRequestDataAddress";
         this.paramRecipeRequestDataAddress.ReadOnly = false;
         this.paramRecipeRequestDataAddress.ShowKeyboard = false;
         this.paramRecipeRequestDataAddress.Size = new System.Drawing.Size(339, 28);
         this.paramRecipeRequestDataAddress.TabIndex = 21;
         this.paramRecipeRequestDataAddress.TextValue = "";
         // 
         // paramRecipeRequestRecipeNoAddress
         // 
         this.paramRecipeRequestRecipeNoAddress.Caption = "Recipe Request Recipe No Address";
         this.paramRecipeRequestRecipeNoAddress.CaptionWidth = 80F;
         this.paramRecipeRequestRecipeNoAddress.Font = new System.Drawing.Font("更紗黑體 UI TC", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
         this.paramRecipeRequestRecipeNoAddress.Location = new System.Drawing.Point(8, 84);
         this.paramRecipeRequestRecipeNoAddress.Margin = new System.Windows.Forms.Padding(5);
         this.paramRecipeRequestRecipeNoAddress.MinimumSize = new System.Drawing.Size(150, 28);
         this.paramRecipeRequestRecipeNoAddress.Name = "paramRecipeRequestRecipeNoAddress";
         this.paramRecipeRequestRecipeNoAddress.ReadOnly = false;
         this.paramRecipeRequestRecipeNoAddress.ShowKeyboard = false;
         this.paramRecipeRequestRecipeNoAddress.Size = new System.Drawing.Size(339, 28);
         this.paramRecipeRequestRecipeNoAddress.TabIndex = 22;
         this.paramRecipeRequestRecipeNoAddress.TextValue = "";
         // 
         // paramRecipeResponseOkAddress
         // 
         this.paramRecipeResponseOkAddress.Caption = "Recipe Response Ok Address";
         this.paramRecipeResponseOkAddress.CaptionWidth = 80F;
         this.paramRecipeResponseOkAddress.Font = new System.Drawing.Font("更紗黑體 UI TC", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
         this.paramRecipeResponseOkAddress.Location = new System.Drawing.Point(8, 122);
         this.paramRecipeResponseOkAddress.Margin = new System.Windows.Forms.Padding(5);
         this.paramRecipeResponseOkAddress.MinimumSize = new System.Drawing.Size(150, 28);
         this.paramRecipeResponseOkAddress.Name = "paramRecipeResponseOkAddress";
         this.paramRecipeResponseOkAddress.ReadOnly = false;
         this.paramRecipeResponseOkAddress.ShowKeyboard = false;
         this.paramRecipeResponseOkAddress.Size = new System.Drawing.Size(339, 28);
         this.paramRecipeResponseOkAddress.TabIndex = 23;
         this.paramRecipeResponseOkAddress.TextValue = "";
         // 
         // paramTextUserControl1
         // 
         this.paramTextUserControl1.Caption = "Recipe Response Ok Address";
         this.paramTextUserControl1.CaptionWidth = 80F;
         this.paramTextUserControl1.Font = new System.Drawing.Font("更紗黑體 UI TC", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
         this.paramTextUserControl1.Location = new System.Drawing.Point(8, 274);
         this.paramTextUserControl1.Margin = new System.Windows.Forms.Padding(5);
         this.paramTextUserControl1.MinimumSize = new System.Drawing.Size(150, 28);
         this.paramTextUserControl1.Name = "paramTextUserControl1";
         this.paramTextUserControl1.ReadOnly = false;
         this.paramTextUserControl1.ShowKeyboard = false;
         this.paramTextUserControl1.Size = new System.Drawing.Size(339, 28);
         this.paramTextUserControl1.TabIndex = 27;
         this.paramTextUserControl1.TextValue = "";
         // 
         // paramRecipeResponseRecipeNoAddress
         // 
         this.paramRecipeResponseRecipeNoAddress.Caption = "Recipe Response Recipe No Address";
         this.paramRecipeResponseRecipeNoAddress.CaptionWidth = 80F;
         this.paramRecipeResponseRecipeNoAddress.Font = new System.Drawing.Font("更紗黑體 UI TC", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
         this.paramRecipeResponseRecipeNoAddress.Location = new System.Drawing.Point(8, 236);
         this.paramRecipeResponseRecipeNoAddress.Margin = new System.Windows.Forms.Padding(5);
         this.paramRecipeResponseRecipeNoAddress.MinimumSize = new System.Drawing.Size(150, 28);
         this.paramRecipeResponseRecipeNoAddress.Name = "paramRecipeResponseRecipeNoAddress";
         this.paramRecipeResponseRecipeNoAddress.ReadOnly = false;
         this.paramRecipeResponseRecipeNoAddress.ShowKeyboard = false;
         this.paramRecipeResponseRecipeNoAddress.Size = new System.Drawing.Size(339, 28);
         this.paramRecipeResponseRecipeNoAddress.TabIndex = 26;
         this.paramRecipeResponseRecipeNoAddress.TextValue = "";
         // 
         // paramRecipeResponseThicknessAddress
         // 
         this.paramRecipeResponseThicknessAddress.Caption = "Recipe Response Thickness Address";
         this.paramRecipeResponseThicknessAddress.CaptionWidth = 80F;
         this.paramRecipeResponseThicknessAddress.Font = new System.Drawing.Font("更紗黑體 UI TC", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
         this.paramRecipeResponseThicknessAddress.Location = new System.Drawing.Point(8, 198);
         this.paramRecipeResponseThicknessAddress.Margin = new System.Windows.Forms.Padding(5);
         this.paramRecipeResponseThicknessAddress.MinimumSize = new System.Drawing.Size(150, 28);
         this.paramRecipeResponseThicknessAddress.Name = "paramRecipeResponseThicknessAddress";
         this.paramRecipeResponseThicknessAddress.ReadOnly = false;
         this.paramRecipeResponseThicknessAddress.ShowKeyboard = false;
         this.paramRecipeResponseThicknessAddress.Size = new System.Drawing.Size(339, 28);
         this.paramRecipeResponseThicknessAddress.TabIndex = 25;
         this.paramRecipeResponseThicknessAddress.TextValue = "";
         // 
         // paramRecipeResponseNgAddress
         // 
         this.paramRecipeResponseNgAddress.Caption = "Recipe Response Ng Address";
         this.paramRecipeResponseNgAddress.CaptionWidth = 80F;
         this.paramRecipeResponseNgAddress.Font = new System.Drawing.Font("更紗黑體 UI TC", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
         this.paramRecipeResponseNgAddress.Location = new System.Drawing.Point(8, 160);
         this.paramRecipeResponseNgAddress.Margin = new System.Windows.Forms.Padding(5);
         this.paramRecipeResponseNgAddress.MinimumSize = new System.Drawing.Size(150, 28);
         this.paramRecipeResponseNgAddress.Name = "paramRecipeResponseNgAddress";
         this.paramRecipeResponseNgAddress.ReadOnly = false;
         this.paramRecipeResponseNgAddress.ShowKeyboard = false;
         this.paramRecipeResponseNgAddress.Size = new System.Drawing.Size(339, 28);
         this.paramRecipeResponseNgAddress.TabIndex = 24;
         this.paramRecipeResponseNgAddress.TextValue = "";
         // 
         // paramRecipeT1TimeoutMs
         // 
         this.paramRecipeT1Timeout.Caption = "Recipe T1 Timeout";
         this.paramRecipeT1Timeout.CaptionWidth = 80F;
         this.paramRecipeT1Timeout.DecimalPlaces = 0;
         this.paramRecipeT1Timeout.Font = new System.Drawing.Font("更紗黑體 UI TC", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
         this.paramRecipeT1Timeout.Increment = 1000D;
         this.paramRecipeT1Timeout.Location = new System.Drawing.Point(8, 310);
         this.paramRecipeT1Timeout.MaxNumber = 99000D;
         this.paramRecipeT1Timeout.MinimumSize = new System.Drawing.Size(150, 28);
         this.paramRecipeT1Timeout.MinNumber = 1000D;
         this.paramRecipeT1Timeout.Name = "paramRecipeT1TimeoutMs";
         this.paramRecipeT1Timeout.Size = new System.Drawing.Size(339, 28);
         this.paramRecipeT1Timeout.TabIndex = 28;
         this.paramRecipeT1Timeout.Value = 1000D;
         // 
         // MelsecBoardSettingForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(759, 600);
         this.Font = new System.Drawing.Font("更紗黑體 UI TC", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
         this.Margin = new System.Windows.Forms.Padding(4);
         this.Name = "MelsecBoardSettingForm";
         this.Text = "MelsecBoardSettingForm";
         this.tabControl1.ResumeLayout(false);
         this.tabGeneral.ResumeLayout(false);
         this.tabGeneral.PerformLayout();
         this.tabApp.ResumeLayout(false);
         this.tabApp.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.numTimeSync)).EndInit();
         this.tabTracking.ResumeLayout(false);
         this.tabTracking.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.numPort)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.numNetwork)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.numTimeout)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.numRetryCount)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.numRetryBackoff)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.numStation)).EndInit();
         this.tpMaintenance.ResumeLayout(false);
         this.tpMoveOut.ResumeLayout(false);
         this.tpRegularReport.ResumeLayout(false);
         this.tpRecipe.ResumeLayout(false);
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.TabPage tabApp;
      private System.Windows.Forms.Label label11;
      private System.Windows.Forms.NumericUpDown numTimeSync;
      private System.Windows.Forms.Label label12;
      private System.Windows.Forms.TextBox txtTrigger;
      private System.Windows.Forms.Label label13;
      private System.Windows.Forms.TextBox txtData;

      // Board Controls
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.NumericUpDown numPort;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.NumericUpDown numNetwork;
      private System.Windows.Forms.Label label7;
      private System.Windows.Forms.NumericUpDown numTimeout;
      private System.Windows.Forms.Label label8;
      private System.Windows.Forms.NumericUpDown numRetryCount;
      private System.Windows.Forms.Label label9;
      private System.Windows.Forms.NumericUpDown numRetryBackoff;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.NumericUpDown numStation;
      private System.Windows.Forms.CheckBox chkIsx64;
      private System.Windows.Forms.Label label10;
      private System.Windows.Forms.ComboBox cmbEndian;

      // Tracking Controls
      private System.Windows.Forms.TabPage tabTracking;
      private System.Windows.Forms.Label label14;
      private System.Windows.Forms.TextBox txtLoadingRobotAddr;
      private System.Windows.Forms.Label label15;
      private System.Windows.Forms.TextBox txtLoadingStationAddr;
      private System.Windows.Forms.Label label16;
      private System.Windows.Forms.TextBox txtUnloadingRobotAddr;
      private System.Windows.Forms.Label label17;
      private System.Windows.Forms.TextBox txtUnloadingStationAddr;
      private GRT.SDK.Framework.Component.ParamTextUserControl paramHeartbeatRequestAddress;
      private GRT.SDK.Framework.Component.ParamTextUserControl paramHeartbeatResponseAddress;
      private GRT.SDK.Framework.Component.ParamNumericUpDownUserControl paramHeartbeatInterval;
      private System.Windows.Forms.TabPage tpMaintenance;
      private GRT.SDK.Framework.Component.ParamNumericUpDownUserControl paramMplcToEqT1Timeout;
      private GRT.SDK.Framework.Component.ParamNumericUpDownUserControl paramMplcToEqT2Timeout;
      private GRT.SDK.Framework.Component.ParamNumericUpDownUserControl paramEqToMplcT2Timeout;
      private GRT.SDK.Framework.Component.ParamNumericUpDownUserControl paramEqToMplcT1Timeout;
      private GRT.SDK.Framework.Component.ParamTextUserControl paramAddrPlcToDeviceRequestPosData;
      private GRT.SDK.Framework.Component.ParamTextUserControl paramAddrDeviceToPlcResponseFlag;
      private GRT.SDK.Framework.Component.ParamTextUserControl paramAddrPlcToDeviceRequestTrackingData;
      private GRT.SDK.Framework.Component.ParamTextUserControl paramAddrPlcToDeviceRequestFlag;
      private GRT.SDK.Framework.Component.ParamTextUserControl paramAddrPositionDataBase;
      private GRT.SDK.Framework.Component.ParamTextUserControl paramAddrDeviceToPlcRequestPosData;
      private GRT.SDK.Framework.Component.ParamTextUserControl paramAddrDeviceToPlcRequestTrackingData;
      private GRT.SDK.Framework.Component.ParamTextUserControl paramAddrDeviceToPlcRequestFlag;
      private GRT.SDK.Framework.Component.ParamTextUserControl paramAddrPlcToDeviceResponseNg;
      private GRT.SDK.Framework.Component.ParamTextUserControl paramAddrPlcToDeviceResponseOk;
      private System.Windows.Forms.TabPage tpMoveOut;
      private GRT.SDK.Framework.Component.ParamNumericUpDownUserControl paramMoveOutT2Timeout;
      private GRT.SDK.Framework.Component.ParamNumericUpDownUserControl paramMoveOutT1Timeout;
      private System.Windows.Forms.TabPage tpRegularReport;
      private GRT.SDK.Framework.Component.ParamNumericUpDownUserControl paramRegularReportInterval;
      private System.Windows.Forms.TabPage tpRecipe;
      private GRT.SDK.Framework.Component.ParamTextUserControl paramRecipeRequestFlagAddress;
      private GRT.SDK.Framework.Component.ParamTextUserControl paramRecipeRequestDataAddress;
      private GRT.SDK.Framework.Component.ParamTextUserControl paramRecipeResponseOkAddress;
      private GRT.SDK.Framework.Component.ParamTextUserControl paramRecipeRequestRecipeNoAddress;
      private GRT.SDK.Framework.Component.ParamTextUserControl paramTextUserControl1;
      private GRT.SDK.Framework.Component.ParamTextUserControl paramRecipeResponseRecipeNoAddress;
      private GRT.SDK.Framework.Component.ParamTextUserControl paramRecipeResponseThicknessAddress;
      private GRT.SDK.Framework.Component.ParamTextUserControl paramRecipeResponseNgAddress;
      private GRT.SDK.Framework.Component.ParamNumericUpDownUserControl paramRecipeT1Timeout;
   }
}

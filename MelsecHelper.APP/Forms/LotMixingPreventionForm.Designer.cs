namespace MelsecHelper.APP.Forms
{
   partial class LotMixingPreventionForm
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
         this.btnAddLotA = new System.Windows.Forms.Button();
         this.btnAddLotB = new System.Windows.Forms.Button();
         this.dgvTrackingData = new System.Windows.Forms.DataGridView();
         this.lblTotalCount = new System.Windows.Forms.Label();
         this.lblLotStats = new System.Windows.Forms.Label();
         this.btnClear = new System.Windows.Forms.Button();
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.chkEnableLotMixingCheck = new System.Windows.Forms.CheckBox();
         this.groupBox2 = new System.Windows.Forms.GroupBox();
         ((System.ComponentModel.ISupportInitialize)(this.dgvTrackingData)).BeginInit();
         this.groupBox1.SuspendLayout();
         this.groupBox2.SuspendLayout();
         this.SuspendLayout();
         // 
         // btnAddLotA
         // 
         this.btnAddLotA.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
         this.btnAddLotA.Location = new System.Drawing.Point(20, 30);
         this.btnAddLotA.Name = "btnAddLotA";
         this.btnAddLotA.Size = new System.Drawing.Size(150, 50);
         this.btnAddLotA.TabIndex = 0;
         this.btnAddLotA.Text = "加入批號 A";
         this.btnAddLotA.UseVisualStyleBackColor = true;
         this.btnAddLotA.Click += new System.EventHandler(this.btnAddLotA_Click);
         // 
         // btnAddLotB
         // 
         this.btnAddLotB.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
         this.btnAddLotB.Location = new System.Drawing.Point(190, 30);
         this.btnAddLotB.Name = "btnAddLotB";
         this.btnAddLotB.Size = new System.Drawing.Size(150, 50);
         this.btnAddLotB.TabIndex = 1;
         this.btnAddLotB.Text = "加入批號 B";
         this.btnAddLotB.UseVisualStyleBackColor = true;
         this.btnAddLotB.Click += new System.EventHandler(this.btnAddLotB_Click);
         // 
         // dgvTrackingData
         // 
         this.dgvTrackingData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.dgvTrackingData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dgvTrackingData.Location = new System.Drawing.Point(15, 30);
         this.dgvTrackingData.Name = "dgvTrackingData";
         this.dgvTrackingData.RowTemplate.Height = 24;
         this.dgvTrackingData.Size = new System.Drawing.Size(750, 350);
         this.dgvTrackingData.TabIndex = 2;
         // 
         // lblTotalCount
         // 
         this.lblTotalCount.AutoSize = true;
         this.lblTotalCount.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
         this.lblTotalCount.Location = new System.Drawing.Point(360, 45);
         this.lblTotalCount.Name = "lblTotalCount";
         this.lblTotalCount.Size = new System.Drawing.Size(62, 18);
         this.lblTotalCount.TabIndex = 3;
         this.lblTotalCount.Text = "總數: 0";
         // 
         // lblLotStats
         // 
         this.lblLotStats.AutoSize = true;
         this.lblLotStats.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
         this.lblLotStats.Location = new System.Drawing.Point(480, 45);
         this.lblLotStats.Name = "lblLotStats";
         this.lblLotStats.Size = new System.Drawing.Size(143, 18);
         this.lblLotStats.TabIndex = 4;
         this.lblLotStats.Text = "批號 A: 0 | 批號 B: 0";
         // 
         // btnClear
         // 
         this.btnClear.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
         this.btnClear.Location = new System.Drawing.Point(670, 35);
         this.btnClear.Name = "btnClear";
         this.btnClear.Size = new System.Drawing.Size(100, 40);
         this.btnClear.TabIndex = 5;
         this.btnClear.Text = "清除資料";
         this.btnClear.UseVisualStyleBackColor = true;
         this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
         // 
         // groupBox1
         // 
         this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.groupBox1.Controls.Add(this.chkEnableLotMixingCheck);
         this.groupBox1.Controls.Add(this.btnAddLotA);
         this.groupBox1.Controls.Add(this.btnClear);
         this.groupBox1.Controls.Add(this.btnAddLotB);
         this.groupBox1.Controls.Add(this.lblLotStats);
         this.groupBox1.Controls.Add(this.lblTotalCount);
         this.groupBox1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
         this.groupBox1.Location = new System.Drawing.Point(12, 12);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(780, 100);
         this.groupBox1.TabIndex = 6;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "批號控制";
         // 
         // chkEnableLotMixingCheck
         // 
         this.chkEnableLotMixingCheck.AutoSize = true;
         this.chkEnableLotMixingCheck.Checked = true;
         this.chkEnableLotMixingCheck.CheckState = System.Windows.Forms.CheckState.Checked;
         this.chkEnableLotMixingCheck.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
         this.chkEnableLotMixingCheck.Location = new System.Drawing.Point(360, 70);
         this.chkEnableLotMixingCheck.Name = "chkEnableLotMixingCheck";
         this.chkEnableLotMixingCheck.Size = new System.Drawing.Size(126, 22);
         this.chkEnableLotMixingCheck.TabIndex = 6;
         this.chkEnableLotMixingCheck.Text = "啟用混批檢查";
         this.chkEnableLotMixingCheck.UseVisualStyleBackColor = true;
         // 
         // groupBox2
         // 
         this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.groupBox2.Controls.Add(this.dgvTrackingData);
         this.groupBox2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
         this.groupBox2.Location = new System.Drawing.Point(12, 118);
         this.groupBox2.Name = "groupBox2";
         this.groupBox2.Size = new System.Drawing.Size(780, 400);
         this.groupBox2.TabIndex = 7;
         this.groupBox2.TabStop = false;
         this.groupBox2.Text = "追蹤資料列表";
         // 
         // LotMixingPreventionForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(804, 530);
         this.Controls.Add(this.groupBox2);
         this.Controls.Add(this.groupBox1);
         this.Name = "LotMixingPreventionForm";
         this.Text = "防混批控制";
         ((System.ComponentModel.ISupportInitialize)(this.dgvTrackingData)).EndInit();
         this.groupBox1.ResumeLayout(false);
         this.groupBox1.PerformLayout();
         this.groupBox2.ResumeLayout(false);
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Button btnAddLotA;
      private System.Windows.Forms.Button btnAddLotB;
      private System.Windows.Forms.DataGridView dgvTrackingData;
      private System.Windows.Forms.Label lblTotalCount;
      private System.Windows.Forms.Label lblLotStats;
      private System.Windows.Forms.Button btnClear;
      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.CheckBox chkEnableLotMixingCheck;
      private System.Windows.Forms.GroupBox groupBox2;
   }
}
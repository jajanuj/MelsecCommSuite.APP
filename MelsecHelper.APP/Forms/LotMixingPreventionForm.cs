using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MelsecHelper.APP.Models;

namespace MelsecHelper.APP.Forms
{
   /// <summary>
   /// 批號變更處理動作
   /// </summary>
   public enum LotChangeAction
   {
      /// <summary>變更母框（繼續加入新批號）</summary>
      ChangeLot,

      /// <summary>基板排出（取消加入）</summary>
      EjectBoard,

      /// <summary>取消操作</summary>
      Cancel
   }

   /// <summary>
   /// 防混批控制表單
   /// </summary>
   public partial class LotMixingPreventionForm : Form
   {
      #region Fields

      private int _currentBoardSequence = 1;

      private List<TrackingData> _trackingDataList = new List<TrackingData>();

      #endregion

      #region Constructors

      public LotMixingPreventionForm()
      {
         InitializeComponent();
         InitializeDataGridView();
      }

      #endregion

      #region Private Methods

      /// <summary>
      /// 初始化 DataGridView
      /// </summary>
      private void InitializeDataGridView()
      {
         dgvTrackingData.AutoGenerateColumns = false;
         dgvTrackingData.AllowUserToAddRows = false;
         dgvTrackingData.AllowUserToDeleteRows = false;
         dgvTrackingData.ReadOnly = true;
         dgvTrackingData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

         // 定義欄位
         dgvTrackingData.Columns.Add(new DataGridViewTextBoxColumn
         {
            Name = "colSequence",
            HeaderText = "序號",
            DataPropertyName = "Sequence",
            Width = 60
         });

         dgvTrackingData.Columns.Add(new DataGridViewTextBoxColumn
         {
            Name = "colBoardId",
            HeaderText = "基板序號",
            DataPropertyName = "BoardIdDisplay",
            Width = 150
         });

         dgvTrackingData.Columns.Add(new DataGridViewTextBoxColumn
         {
            Name = "colLotNo",
            HeaderText = "批號",
            DataPropertyName = "LotNoDisplay",
            Width = 120
         });

         dgvTrackingData.Columns.Add(new DataGridViewTextBoxColumn
         {
            Name = "colLayerCount",
            HeaderText = "層數",
            DataPropertyName = "LayerCount",
            Width = 60
         });

         dgvTrackingData.Columns.Add(new DataGridViewTextBoxColumn
         {
            Name = "colJudgeFlags",
            HeaderText = "判斷旗標",
            DataPropertyName = "JudgeFlagsDisplay",
            Width = 100
         });
      }

      /// <summary>
      /// 創建批號 A 的追蹤資料
      /// </summary>
      private TrackingData CreateLotAData()
      {
         return new TrackingData
         {
            BoardId = new ushort[] { (ushort)_currentBoardSequence, 0x0001, 0x0000 },
            LayerCount = 4,
            LotNoChar = (ushort)'A', // 批號 A
            LotNoNum = 20250122,     // 批號數字部分
            JudgeFlag1 = 0,
            JudgeFlag2 = 0,
            JudgeFlag3 = 0
         };
      }

      /// <summary>
      /// 創建批號 B 的追蹤資料
      /// </summary>
      private TrackingData CreateLotBData()
      {
         return new TrackingData
         {
            BoardId = new ushort[] { (ushort)_currentBoardSequence, 0x0002, 0x0000 },
            LayerCount = 6,
            LotNoChar = (ushort)'B', // 批號 B
            LotNoNum = 20250122,     // 批號數字部分
            JudgeFlag1 = 0,
            JudgeFlag2 = 0,
            JudgeFlag3 = 0
         };
      }

      /// <summary>
      /// 更新 DataGridView 顯示
      /// </summary>
      private void RefreshDataGridView()
      {
         var displayData = _trackingDataList.Select((data, index) => new
         {
            Sequence = index + 1,
            BoardIdDisplay = data.FormatBoardId(),
            LotNoDisplay = data.FormatLotNo(),
            LayerCount = data.LayerCount,
            JudgeFlagsDisplay = $"{data.JudgeFlag1:X2}-{data.JudgeFlag2:X2}-{data.JudgeFlag3:X2}"
         }).ToList();

         dgvTrackingData.DataSource = null;
         dgvTrackingData.DataSource = displayData;

         // 更新統計資訊
         lblTotalCount.Text = $"總數: {_trackingDataList.Count}";

         var lotACount = _trackingDataList.Count(d => d.LotNoChar == 'A');
         var lotBCount = _trackingDataList.Count(d => d.LotNoChar == 'B');
         lblLotStats.Text = $"批號 A: {lotACount} | 批號 B: {lotBCount}";
      }

      /// <summary>
      /// 檢查批號混批情況
      /// </summary>
      /// <param name="newData">新加入的追蹤資料</param>
      /// <param name="action">使用者選擇的動作</param>
      /// <returns>是否允許加入（true=允許, false=取消）</returns>
      private bool CheckLotMixing(TrackingData newData, out LotChangeAction action)
      {
         action = LotChangeAction.ChangeLot; // 預設動作

         // 如果未啟用混批檢查，直接允許
         if (!chkEnableLotMixingCheck.Checked)
         {
            return true;
         }

         // 如果列表為空，直接允許
         if (_trackingDataList.Count == 0)
         {
            return true;
         }

         // 取得最後一筆資料
         var lastData = _trackingDataList[_trackingDataList.Count - 1];

         // 比對批號（LotNoChar 和 LotNoNum）
         bool isDifferentLot = lastData.LotNoChar != newData.LotNoChar ||
                               lastData.LotNoNum != newData.LotNoNum;

         if (isDifferentLot)
         {
            string lastLotNo = $"{(char)lastData.LotNoChar}{lastData.LotNoNum:D8}";
            string newLotNo = $"{(char)newData.LotNoChar}{newData.LotNoNum:D8}";

            var result = MessageBox.Show(
               $"警告：批號變更！\n\n" +
               $"前一批號：{lastLotNo}\n" +
               $"新批號：{newLotNo}\n\n" +
               $"請選擇處理方式：\n" +
               $"• 是(Y)：變更母框\n" +
               $"• 否(N)：基板排出\n" +
               $"• 取消：返回",
               "批號變更警告",
               MessageBoxButtons.YesNoCancel,
               MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
               action = LotChangeAction.ChangeLot;
               return true; // 允許加入新批號
            }
            else if (result == DialogResult.No)
            {
               action = LotChangeAction.EjectBoard;
               return false; // 不加入，執行排出
            }
            else // Cancel
            {
               action = LotChangeAction.Cancel;
               return false; // 取消操作
            }
         }

         return true;
      }

      #endregion

      #region Event Handlers

      /// <summary>
      /// 加入批號 A
      /// </summary>
      private void btnAddLotA_Click(object sender, EventArgs e)
      {
         var trackingData = CreateLotAData();

         // 檢查批號混批
         if (!CheckLotMixing(trackingData, out LotChangeAction action))
         {
            // 根據使用者選擇的動作處理
            if (action == LotChangeAction.EjectBoard)
            {
               MessageBox.Show(
                  $"基板排出\n\n" +
                  $"批號：{trackingData.FormatLotNo()}\n" +
                  $"基板序號：{trackingData.FormatBoardId()}",
                  "基板排出",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
            }

            return; // 不加入資料
         }

         _trackingDataList.Add(trackingData);
         _currentBoardSequence++;

         RefreshDataGridView();
      }

      /// <summary>
      /// 加入批號 B
      /// </summary>
      private void btnAddLotB_Click(object sender, EventArgs e)
      {
         var trackingData = CreateLotBData();

         // 檢查批號混批
         if (!CheckLotMixing(trackingData, out LotChangeAction action))
         {
            // 根據使用者選擇的動作處理
            if (action == LotChangeAction.EjectBoard)
            {
               MessageBox.Show(
                  $"基板排出\n\n" +
                  $"批號：{trackingData.FormatLotNo()}\n" +
                  $"基板序號：{trackingData.FormatBoardId()}",
                  "基板排出",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
            }

            return; // 不加入資料
         }

         _trackingDataList.Add(trackingData);
         _currentBoardSequence++;

         RefreshDataGridView();
      }

      /// <summary>
      /// 清除所有資料
      /// </summary>
      private void btnClear_Click(object sender, EventArgs e)
      {
         if (MessageBox.Show("確定要清除所有追蹤資料嗎？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
         {
            _trackingDataList.Clear();
            _currentBoardSequence = 1;
            RefreshDataGridView();
         }
      }

      #endregion
   }
}
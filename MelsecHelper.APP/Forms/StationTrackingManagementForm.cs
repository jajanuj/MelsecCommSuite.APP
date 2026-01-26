using Melsec.Helper.Interfaces;
using MelsecHelper.APP.Models;
using MelsecHelper.APP.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MelsecHelper.APP.Forms
{
   /// <summary>
   /// 站別追蹤資料管理表單
   /// </summary>
   public partial class StationTrackingManagementForm : Form
   {
      #region Fields

      private readonly AppPlcService _appPlcService;
      private readonly ICCLinkController _controller;

      private readonly CancellationTokenSource _cts = new CancellationTokenSource();

      private readonly TrackingDataService _service;
      private readonly AppControllerSettings _settings;
      private MoveOutService _moveOutService;

      #endregion

      #region Constructors

      /// <summary>
      /// 建構子
      /// </summary>
      /// <param name="appPlcService"></param>
      /// <param name="configPath">配置檔路徑</param>
      public StationTrackingManagementForm(AppPlcService appPlcService, AppControllerSettings settings, string configPath)
      {
         InitializeComponent();
         _appPlcService = appPlcService;
         _controller = appPlcService.Controller;
         _settings = settings;

         _service = new TrackingDataService(_controller, configPath);
         _moveOutService = new MoveOutService(_appPlcService, _settings, msg => Log($"[MoveOut] {msg}"));
         _moveOutService.MoveOutCompleted += OnMoveOutServiceOnMoveOutCompleted;

         InitializeStationComboBoxes();
         InitializeJudgmentResultComboBox();
      }

      #endregion

      #region Protected Methods

      protected override void OnFormClosing(FormClosingEventArgs e)
      {
         _cts?.Cancel();
         base.OnFormClosing(e);
      }

      #endregion

      #region Private Methods

      private async void OnMoveOutServiceOnMoveOutCompleted(string startAddress)
      {
         try
         {
            // 先處理 Last Flag 傳遞（在清除之前讀取資料）
            // 返回 true 表示可以繼續清除，false 表示用戶選擇不清除
            bool shouldClear = await _service.HandleLastFlagTransferAsync(startAddress, _cts.Token);

            if (!shouldClear)
            {
               Log($"[MoveOut] 用戶選擇不清除資料。Start Address: {startAddress}");
               return;
            }

            // 然後清除資料
            await _service.ClearDataByAddressAsync(startAddress, _cts.Token);

            Log($"[MoveOut] MoveOut Completed. Start Address: {startAddress}");
         }
         catch (Exception e)
         {
            Log($"[MoveOut] MoveOut Failed. Start Address: {startAddress}. Error: {e.Message}");
         }
      }

      private void ClearPositionData()
      {
      }

      /// <summary>
      /// 初始化判斷結果下拉選單
      /// </summary>
      private void InitializeJudgmentResultComboBox()
      {
         cboJudgmentResult.Items.Clear();
         cboJudgmentResult.DisplayMember = "Text";
         cboJudgmentResult.ValueMember = "Value";

         var items = new[]
         {
            new { Text = "OK - 良品", Value = (int)JudgmentResult.OK },
            new { Text = "NG - 不良品", Value = (int)JudgmentResult.NG },
            new { Text = "PD - 待定", Value = (int)JudgmentResult.PD }
         };

         foreach (var item in items)
         {
            cboJudgmentResult.Items.Add(item);
         }

         cboJudgmentResult.SelectedIndex = 0;
      }

      /// <summary>
      /// 當 OK/NG/PD 選擇改變時，自動更新 Bit 15-14
      /// </summary>
      private void cboJudgmentResult_SelectedIndexChanged(object sender, EventArgs e)
      {
         UpdateJudgeFlag2FromControls();
      }

      /// <summary>
      /// 當 Last Flag 勾選改變時，自動更新 Bit 13
      /// </summary>
      private void chkLastFlag_CheckedChanged(object sender, EventArgs e)
      {
         UpdateJudgeFlag2FromControls();
      }

      /// <summary>
      /// 根據控制項設定自動計算並更新 nudJudge2 的值（僅修改 Bit 13-15）
      /// </summary>
      private void UpdateJudgeFlag2FromControls()
      {
         if (cboJudgmentResult.SelectedItem == null)
         {
            return;
         }

         // 讀取當前值
         ushort currentValue = (ushort)nudJudge2.Value;

         // 清除 Bit 15-14，保留其他位元 (AND with 0x3FFF)
         ushort cleared = (ushort)(currentValue & 0x3FFF);

         // 設定 Bit 15-14 (OK/NG/PD)
         // 使用動態型別取得 Value 屬性
         dynamic selectedItem = cboJudgmentResult.SelectedItem;
         int result = (int)selectedItem.Value;
         ushort withResult = (ushort)(cleared | (result << 14));

         // 設定/清除 Bit 13 (Last Flag)
         if (chkLastFlag.Checked)
         {
            withResult |= 1 << 13;
         }
         else
         {
            withResult &= unchecked((ushort)~(1 << 13));
         }

         // 更新顯示
         nudJudge2.Value = withResult;
      }

      /// <summary>
      /// 初始化站別下拉選單
      /// </summary>
      private void InitializeStationComboBoxes()
      {
         var stations = _service.GetAllStations();

         // 建立顯示項目 (站號 - 站名)
         var displayItems = stations.Select(s => new
         {
            Display = $"{s.StationId:D2} - {s.StationName} ({s.Capacity}片)",
            Value = s.StationId
         }).ToList();

         // 情境 1: 單片更新
         cboStation1.DisplayMember = "Display";
         cboStation1.ValueMember = "Value";
         cboStation1.DataSource = new List<object>(displayItems);

         // 情境 2: 站別切換 (來源站)
         cmbFromStation.DisplayMember = "Display";
         cmbFromStation.ValueMember = "Value";
         cmbFromStation.DataSource = new List<object>(displayItems);

         // 情境 2: 站別切換 (目標站)
         cmbToStation.DisplayMember = "Display";
         cmbToStation.ValueMember = "Value";
         cmbToStation.DataSource = new List<object>(displayItems);

         // 情境 3: 單片站更新
         var singleCapacityStations = stations.Where(s => s.Capacity == 1)
            .Select(s => new
            {
               Display = $"{s.StationId:D2} - {s.StationName}",
               Value = s.StationId
            }).ToList();

         cmbStation3.DisplayMember = "Display";
         cmbStation3.ValueMember = "Value";
         cmbStation3.DataSource = singleCapacityStations;

         // 查找功能
         cmbQueryStation.DisplayMember = "Display";
         cmbQueryStation.ValueMember = "Value";
         cmbQueryStation.DataSource = new List<object>(displayItems);
      }

      private void cmbStation1_SelectedIndexChanged(object sender, EventArgs e)
      {
         if (cboStation1.SelectedValue is int stationId)
         {
            var station = _service.GetStation(stationId);
            if (station != null)
            {
               nudSlotIndex.Maximum = station.Capacity;
               nudSlotIndex.Value = 1;
               lblCapacity1.Text = $"容量: {station.Capacity} 片";
            }
         }
      }

      private async void btnUpdate1_Click(object sender, EventArgs e)
      {
         if (!(cboStation1.SelectedValue is int stationId))
         {
            return;
         }

         try
         {
            btnUpdate1.Enabled = false;

            // 從輸入欄位建立 TrackingData
            int slotIndex = (int)nudSlotIndex.Value;
            var data = CreateTrackingDataFromInputs(stationId, slotIndex);

            // 更新
            bool success = await _service.UpdateSingleSlotAsync(stationId, slotIndex, data, _cts.Token);

            if (success)
            {
               Log($"[情境1] 成功更新站別 {stationId} 位置 {slotIndex}");
               MessageBox.Show($"成功更新站別 {stationId} 位置 {slotIndex}", "成功",
                  MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
         }
         catch (Exception ex)
         {
            Log($"[情境1] 錯誤: {ex.Message}");
         }
         finally
         {
            btnUpdate1.Enabled = true;
         }
      }

      private async void btnTransfer_Click(object sender, EventArgs e)
      {
         if (!(cmbFromStation.SelectedValue is int fromStationId) ||
             !(cmbToStation.SelectedValue is int toStationId))
         {
            return;
         }

         var fromStation = _service.GetStation(fromStationId);
         var toStation = _service.GetStation(toStationId);

         // 確認對話框
         var result = MessageBox.Show(
            $"確定要將資料從以下站別轉移嗎？\n\n" +
            $"來源: 站別 {fromStationId} - {fromStation.StationName} ({fromStation.Capacity}片)\n" +
            $"目標: 站別 {toStationId} - {toStation.StationName} ({toStation.Capacity}片)\n\n" +
            $"注意: 此操作將覆蓋目標站的所有資料！",
            "確認轉移",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);

         if (result != DialogResult.Yes)
         {
            return;
         }

         try
         {
            btnTransfer.Enabled = false;

            bool success = await _service.TransferStationDataAsync(fromStationId, toStationId, _cts.Token);

            if (success)
            {
               Log($"[情境2] 成功轉移: 站別 {fromStationId} → {toStationId}");
               MessageBox.Show($"成功轉移資料！", "成功",
                  MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
         }
         catch (Exception ex)
         {
            Log($"[情境2] 錯誤: {ex.Message}");
         }
         finally
         {
            btnTransfer.Enabled = true;
         }
      }

      private async void btnUpdate3_Click(object sender, EventArgs e)
      {
         if (!(cmbStation3.SelectedValue is int stationId))
         {
            return;
         }

         try
         {
            btnUpdate3.Enabled = false;

            var data = CreateTrackingDataFromInputs();
            bool success = await _service.UpdateSingleCapacityStationAsync(stationId, data, _cts.Token);

            if (success)
            {
               Log($"[情境3] 成功更新單片站 {stationId}");
               MessageBox.Show($"成功更新單片站 {stationId}", "成功",
                  MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
         }
         catch (Exception ex)
         {
            Log($"[情境3] 錯誤: {ex.Message}");
         }
         finally
         {
            btnUpdate3.Enabled = true;
         }
      }

      private void cmbQueryStation_SelectedIndexChanged(object sender, EventArgs e)
      {
         if (cmbQueryStation.SelectedValue is int stationId)
         {
            var station = _service.GetStation(stationId);
            if (station != null)
            {
               nudQuerySlot.Maximum = station.Capacity;
               nudQuerySlot.Value = 1;
               lblQueryCapacity.Text = $"容量: {station.Capacity} 片";
            }
         }
      }

      private async void btnQuery_Click(object sender, EventArgs e)
      {
         if (!(cmbQueryStation.SelectedValue is int stationId))
         {
            return;
         }

         try
         {
            btnQuery.Enabled = false;

            int slotIndex = (int)nudQuerySlot.Value;
            var data = await _service.ReadSlotDataAsync(stationId, slotIndex, _cts.Token);

            if (data != null)
            {
               DisplayTrackingData(data);
               Log($"[查找] 讀取站別 {stationId} 位置 {slotIndex}");
            }
         }
         catch (Exception ex)
         {
            Log($"[查找] 錯誤: {ex.Message}");
         }
         finally
         {
            btnQuery.Enabled = true;
         }
      }

      /// <summary>
      /// 從輸入欄位建立 TrackingData
      /// </summary>
      private TrackingData CreateTrackingDataFromInputs(int stationIndex = 0, int slotIndex = 0)
      {
         var station = _service.GetStation(stationIndex);
         var startAddress = station.CalculateSlotAddress(slotIndex);
         return new TrackingData
         {
            StartAddress = startAddress,
            BoardId = new[]
            {
               (ushort)nudBoardId1.Value,
               (ushort)nudBoardId2.Value,
               (ushort)nudBoardId3.Value
            },
            LayerCount = (ushort)nudLayerCount.Value,
            LotNoChar = string.IsNullOrEmpty(txtLotChar.Text) ? (ushort)0 : (ushort)txtLotChar.Text[0],
            LotNoNum = (uint)nudLotNum.Value,
            JudgeFlag1 = (ushort)nudJudge1.Value,
            JudgeFlag2 = (ushort)nudJudge2.Value,
            JudgeFlag3 = (ushort)nudJudge3.Value
         };
      }

      /// <summary>
      /// 顯示追蹤資料
      /// </summary>
      private void DisplayTrackingData(TrackingData data)
      {
         txtQueryResult.Text = $"基板序號: {data.FormatBoardId()}\r\n" +
                               $"基板層數: {data.LayerCount}\r\n" +
                               $"批號: {data.FormatLotNo()}\r\n" +
                               $"判斷旗標1: {data.JudgeFlag1}\r\n" +
                               $"判斷旗標2: {data.JudgeFlag2}\r\n" +
                               $"判斷旗標3: {data.JudgeFlag3}";

         // 同時更新輸入欄位
         nudBoardId1.Value = data.BoardId[0];
         nudBoardId2.Value = data.BoardId[1];
         nudBoardId3.Value = data.BoardId[2];
         nudLayerCount.Value = data.LayerCount;
         txtLotChar.Text = data.LotNoChar > 0 ? ((char)data.LotNoChar).ToString() : "";
         nudLotNum.Value = data.LotNoNum;
         nudJudge1.Value = data.JudgeFlag1;
         nudJudge2.Value = data.JudgeFlag2;
         nudJudge3.Value = data.JudgeFlag3;
      }

      /// <summary>
      /// 記錄訊息到 Log 控制項（執行緒安全）
      /// </summary>
      private void Log(string message)
      {
         if (rtbLog.InvokeRequired)
         {
            rtbLog.Invoke(new Action<string>(Log), message);
            return;
         }

         rtbLog.AppendText($"{DateTime.Now:HH:mm:ss} | {message}{Environment.NewLine}");
         rtbLog.ScrollToCaret();
      }

      private async void btnMoveOut_Click(object sender, EventArgs e)
      {
         try
         {
            _moveOutService.Start();

            if (!(cboStation1.SelectedValue is int stationId))
            {
               return;
            }

            btnMoveOut.Enabled = false;

            // 從輸入欄位建立 TrackingData
            var slotIndex = (int)nudSlotIndex.Value;
            var data = CreateTrackingDataFromInputs(stationId, slotIndex);
            RunMoveOutTest(new MoveOutData { ReasonCode = 0, TrackingData = data });
         }
         catch (Exception ex)
         {
            Log($"[情境1] 錯誤: {ex.Message}");
         }
         finally
         {
            btnMoveOut.Enabled = true;
         }
      }

      /// <summary>
      /// MoveOutService 測試範例
      /// </summary>
      /// <param name="moveOutData"></param>
      private async void RunMoveOutTest(MoveOutData moveOutData)
      {
         try
         {
            if (_moveOutService == null)
            {
               Log("MoveOutService not initialized.");
               return;
            }

            Log("[Test] 開始 MoveOut 測試...");
            await _moveOutService.StartMoveOut(moveOutData);
         }
         catch (Exception ex)
         {
            Log($"[Test] MoveOut 測試失敗: {ex.Message}");
         }
      }

      private async void btnSetSituation1_Click(object sender, EventArgs e)
      {
         int slotIndex = 1;
         var stationId = 3;
         var station = _service.GetStation(stationId);
         var startAddress = station.CalculateSlotAddress(slotIndex);
         var data = new TrackingData
         {
            StartAddress = startAddress,
            BoardId = new[]
            {
               (ushort)11,
               (ushort)22,
               (ushort)3
            },
            LayerCount = 44,
            LotNoChar = 'A',
            LotNoNum = 456,
            JudgeFlag1 = 8888,
            JudgeFlag2 = 8207,
            JudgeFlag3 = 9999
         };

         await _service.UpdateSingleSlotAsync(stationId, slotIndex, data, _cts.Token);

         stationId = 4;
         slotIndex = 2;
         station = _service.GetStation(stationId);
         startAddress = station.CalculateSlotAddress(slotIndex);
         data = new TrackingData
         {
            StartAddress = startAddress,
            BoardId = new[]
            {
               (ushort)11,
               (ushort)22,
               (ushort)2
            },
            LayerCount = 44,
            LotNoChar = 'A',
            LotNoNum = 456,
            JudgeFlag1 = 8888,
            JudgeFlag2 = 15,
            JudgeFlag3 = 9999
         };
         await _service.UpdateSingleSlotAsync(stationId, slotIndex, data, _cts.Token);

         stationId = 4;
         slotIndex = 1;
         station = _service.GetStation(stationId);
         startAddress = station.CalculateSlotAddress(slotIndex);
         data = new TrackingData
         {
            StartAddress = startAddress,
            BoardId = new[]
            {
               (ushort)11,
               (ushort)22,
               (ushort)1
            },
            LayerCount = 44,
            LotNoChar = 'A',
            LotNoNum = 456,
            JudgeFlag1 = 8888,
            JudgeFlag2 = 15,
            JudgeFlag3 = 9999
         };
         await _service.UpdateSingleSlotAsync(stationId, slotIndex, data, _cts.Token);
      }

      #endregion
   }
}
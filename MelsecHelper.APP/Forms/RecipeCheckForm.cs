using Melsec.Helper.Interfaces;
using MelsecHelper.APP.Models;
using MelsecHelper.APP.Services;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MelsecHelper.APP.Forms
{
   public partial class RecipeCheckForm : Form
   {
      #region Fields

      private readonly AppPlcService _appPlcService;
      private readonly ICCLinkController _controller;
      private readonly PlcSimulator _simulator; // 新增模擬器引用
      private RecipeCheckClient _client;

      private bool _isOnline;
      private RecipeCheckSettings _settings;

      #endregion

      #region Constructors

      public RecipeCheckForm(AppPlcService appPlcService, AppControllerSettings settings, PlcSimulator simulator = null)
      {
         InitializeComponent();
         _appPlcService = appPlcService ?? throw new ArgumentNullException(nameof(appPlcService));
         _controller = _appPlcService.Controller ?? throw new ArgumentNullException(nameof(_appPlcService.Controller));
         _simulator = simulator; // 儲存模擬器引用

         // 初始化設定
         _settings = settings.RecipeCheck;

         // 初始化 UI 狀態
         UpdateUiMode();

         // 綁定模式驗證事件
         chkEnableCheckLogMixing.CheckedChanged += (s, e) => ValidateMode();
         chkEnableAutoRecipe.CheckedChanged += (s, e) => ValidateMode();

         // 初始驗證
         ValidateMode();
      }

      #endregion

      #region Properties

      /// <summary>
      /// 取得 or 設定目前連線狀態 (由主表單同步)
      /// </summary>
      public bool IsOnline
      {
         get => _isOnline;
         set
         {
            if (_isOnline != value)
            {
               _isOnline = value;
               // 確保在 UI 執行緒執行
               if (InvokeRequired)
               {
                  Invoke(new Action(() => ValidateMode()));
               }
               else
               {
                  ValidateMode();
               }
            }
         }
      }

      #endregion

      #region Private Methods

      private void ValidateMode()
      {
         if (InvokeRequired)
         {
            Invoke(new Action(ValidateMode));
            return;
         }

         bool isLotMix = chkEnableCheckLogMixing.Checked;
         bool isAutoRecipe = chkEnableAutoRecipe.Checked;

         // 檢查分配禁止 (Forbidden)
         // 自動配方設定 (C=ON) 必須搭配 Online (A=ON) 與 Lot混載 (B=ON)
         bool isForbidden = isAutoRecipe && (!IsOnline || !isLotMix);

         if (isForbidden)
         {
            btnSend.Enabled = false;
            lblResult.Text = "分配禁止 (自動配方需 Online + Lot混載)";
            lblResult.ForeColor = Color.Red;
         }
         else
         {
            btnSend.Enabled = true;
            // 若之前是顯示禁止訊息，則恢復為預設狀態
            if (lblResult.Text.StartsWith("分配禁止"))
            {
               lblResult.Text = "狀態: 等待中";
               lblResult.ForeColor = Color.Black;
            }
         }
      }

      private void rdoMode_CheckedChanged(object sender, EventArgs e)
      {
         UpdateUiMode();
      }

      private void UpdateUiMode()
      {
         bool isNumeric = rdoNumeric.Checked;
         txtRecipeNo.Enabled = isNumeric;
         txtRecipeName.Enabled = !isNumeric;

         // 更新設定中的模式
         _settings.Mode = isNumeric ? RecipeCheckMode.Numeric : RecipeCheckMode.String;
      }

      private async void btnSend_Click(object sender, EventArgs e)
      {
         bool isLotMix = chkEnableCheckLogMixing.Checked;
         bool isAutoRecipe = chkEnableAutoRecipe.Checked;

         // 1. 檢查分配禁止 (Forbidden) - 這裡雖有 ValidateMode 擋住按鈕，但保留雙重確認
         if (isAutoRecipe)
         {
            if (!IsOnline || !isLotMix)
            {
               MessageBox.Show("分配禁止: 自動配方設定需同時開啟'在線設定'與'Lot混載確認'", "操作禁止", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               // 確保狀態同步
               ValidateMode();
               return;
            }
         }

         try
         {
            btnSend.Enabled = false;

            // 2. 執行對應流程
            if (isAutoRecipe)
            {
               // A=ON, B=ON, C=ON -> 實施配方確認 IF、Lot混載確認
               await ExecuteRecipeCheckAsync();
               await ExecuteLotMixingCheckAsync();
            }
            else
            {
               if (isLotMix)
               {
                  // B=ON, C=OFF -> 僅實施 Lot 混載確認
                  await ExecuteLotMixingCheckAsync();
               }
               else
               {
                  // B=OFF, C=OFF -> 配方確認 IF (不進行 Lot 混載確認)
                  await ExecuteRecipeCheckAsync();
               }
            }
         }
         catch (Exception ex)
         {
            Log($"發生錯誤: {ex.Message}");
            lblResult.Text = "狀態: 錯誤";
            lblResult.ForeColor = Color.Red;
            MessageBox.Show($"執行失敗: {ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
         }
         finally
         {
            btnSend.Enabled = true;
            // 執行後再次驗證按鈕狀態 (避免狀態改變而被錯誤啟用)
            ValidateMode();
         }
      }

      private async Task ExecuteRecipeCheckAsync()
      {
         lblResult.Text = "狀態: 檢查中 (Recipe)...";
         lblResult.ForeColor = Color.Blue;
         Log("開始發送 Recipe Check 請求...");

         // 如果有模擬器，自動啟動模擬器流程
         if (_simulator != null)
         {
            Log("[模擬模式] 自動啟動模擬器流程...");
            //_simulator.StartRecipeCheckMode(_settings);
         }

         // 準備追蹤資料
         short[] trackingData = ParseTrackingData(txtTrackingData.Text);

         // 準備 Recipe 參數
         ushort? recipeNo = null;
         string recipeName = null;

         if (rdoNumeric.Checked)
         {
            if (ushort.TryParse(txtRecipeNo.Text, out ushort no))
            {
               recipeNo = no;
            }
            else
            {
               MessageBox.Show("Recipe No. 必須是有效的數字 (0-65535)", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
               return;
            }
         }
         else
         {
            recipeName = txtRecipeName.Text;
         }

         // 建立 Client
         _client = new RecipeCheckClient(_appPlcService, _settings, Log);

         // 發送請求
         var response = await _client.SendRequestAsync(trackingData, recipeNo, recipeName);

         // 顯示結果
         DisplayResponse(response);
      }

      private Task ExecuteLotMixingCheckAsync()
      {
         Log("執行 Lot 混載確認... (尚未實作)");
         // TODO: 實作 Lot 混載確認邏輯
         return Task.CompletedTask;
      }

      private short[] ParseTrackingData(string input)
      {
         try
         {
            var parts = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var data = new short[10];

            for (int i = 0; i < 10 && i < parts.Length; i++)
            {
               if (int.TryParse(parts[i], System.Globalization.NumberStyles.Number, null, out int hexVal))
               {
                  // 支援十六進位輸入 (如 0xFFFF)
                  data[i] = (short)hexVal;
               }
            }

            return data;
         }
         catch
         {
            Log("追蹤資料解析失敗，使用預設值 (全0)");
            return new short[10];
         }
      }

      private void DisplayResponse(RecipeCheckResponse response)
      {
         lblResponseTime.Text = $"回應時間: {response.ResponseTime:HH:mm:ss.fff}";

         if (response.IsTimeout)
         {
            lblResult.Text = "狀態: 超時 (Timeout)";
            lblResult.ForeColor = Color.Red;
            lblThickness.Text = "板厚: N/A";
            lblResponseRecipe.Text = "Recipe: N/A";
         }
         else
         {
            lblResult.Text = response.IsOK ? "狀態: OK" : "狀態: NG";
            lblResult.ForeColor = response.IsOK ? Color.Green : Color.Red;

            lblThickness.Text = $"板厚: {response.BoardThickness}";

            if (_settings.Mode == RecipeCheckMode.Numeric)
            {
               lblResponseRecipe.Text = $"Recipe No.: {response.RecipeNo}";
            }
            else
            {
               lblResponseRecipe.Text = $"Recipe Name: {response.RecipeName}";
            }
         }
      }

      private void Log(string message)
      {
         if (InvokeRequired)
         {
            Invoke(new Action<string>(Log), message);
            return;
         }

         string timestamp = DateTime.Now.ToString("HH:mm:ss.fff");
         txtLog.AppendText($"[{timestamp}] {message}{Environment.NewLine}");
      }

      #endregion
   }
}
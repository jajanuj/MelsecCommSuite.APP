using System;

namespace MelsecHelper.APP.Services
{
    /// <summary>
    /// 訊號防彈跳處理器
    /// </summary>
    public class SignalDebouncer
    {
        private readonly int _debounceTimeMs;
        private bool _lastRawState;
        private bool _stableState;
        private DateTime _lastChangeTime;

        /// <summary>
        /// 初始化防彈跳處理器
        /// </summary>
        /// <param name="debounceTimeMs">穩定時間 (毫秒)，預設 50ms</param>
        public SignalDebouncer(int debounceTimeMs = 50)
        {
            _debounceTimeMs = debounceTimeMs;
            _lastChangeTime = DateTime.MinValue;
        }

        /// <summary>
        /// 處理輸入訊號並回傳穩定後的狀態
        /// </summary>
        /// <param name="rawInput">原始輸入訊號</param>
        /// <returns>穩定後的訊號狀態</returns>
        public bool Process(bool rawInput)
        {
            // 如果原始訊號發生變化，記錄時間
            if (rawInput != _lastRawState)
            {
                _lastRawState = rawInput;
                _lastChangeTime = DateTime.Now;
            }

            // 如果距離上次變化的時間超過設定的防彈跳時間，則更新穩定狀態
            if ((DateTime.Now - _lastChangeTime).TotalMilliseconds >= _debounceTimeMs)
            {
                _stableState = rawInput;
            }

            return _stableState;
        }

        /// <summary>
        /// 重置狀態
        /// </summary>
        public void Reset()
        {
            _lastRawState = false;
            _stableState = false;
            _lastChangeTime = DateTime.MinValue;
        }

        /// <summary>
        /// 取得當前穩定狀態 (不更新)
        /// </summary>
        public bool CurrentState => _stableState;
    }
}

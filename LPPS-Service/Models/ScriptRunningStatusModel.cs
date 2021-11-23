using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LPPS_Service.Models
{
    public class ScriptRunningStatusModel
    {
        public string scriptName { get; set; }
        public string currentProgress { get; set; }
        public bool isRunning { get; set; }
        public DateTime lastTestStartTime { get; set; }

        /// <summary>
        /// 上次測試結束的時間
        /// </summary>
        public DateTime lastTestEndTime { get; set; }

        /// <summary>
        /// 測試結束的時間
        /// </summary>
        public DateTime currentTestEndTime { get; set; }
        /// <summary>
        /// 倒數計時字串
        /// </summary>
        public string countDownText { get; set; }
    }
}

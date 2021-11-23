using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LPPS_Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LPPSController : ControllerBase
    {
        /// <summary>
        /// QC完成手動紀錄
        /// </summary>
        /// <returns></returns>
        [HttpGet("QCManualRecordFinish")]
        public async Task<IActionResult> QCManualRecordFinish()
        {
            return Ok(DateTime.Now);
        }

        /// <summary>
        /// 裝置PORT的開啟狀態
        /// </summary>
        /// <param name="status"></param>
        /// <returns></returns>
        [HttpPost("DevicesStatus")]
        public async Task<IActionResult> DevicesStatus(Models.DevicesStatusModel status)
        {
            return Ok(status);
        }


        [HttpPost("ScriptRunningStatus")]
        public async Task<IActionResult> ScriptRunningStatus(Models.ScriptRunningStatusModel[] testScripts)
        {
            return Ok(testScripts);
        }
    }
}

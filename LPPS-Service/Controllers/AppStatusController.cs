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
    public class AppStatusController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> KeepAlive()
        {
            return Ok("Alive...");
        }
    }
}

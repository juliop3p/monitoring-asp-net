using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading;

namespace MonitoringApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BaseController : ControllerBase
    {
        public ActionResult<object> DefaultRespose(object result)
        {
            var rnd = new Random();
            var random = rnd.Next(1, 100);

            Thread.Sleep(1000);

            if (random < 2)
            {
                return StatusCode(500);
            }
            else if (random < 6)
            {

                
                return BadRequest(result);
            }


            return Ok(result);
        }
    }
}

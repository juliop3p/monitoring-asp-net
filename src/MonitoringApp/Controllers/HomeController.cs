using Microsoft.AspNetCore.Mvc;

namespace MonitoringApp.Controllers
{
    public class HomeController : BaseController
    {

        [HttpGet]
        public ActionResult<object> Home()
        {
            return DefaultRespose("<h1>Home</h1>");
        }
    }
}

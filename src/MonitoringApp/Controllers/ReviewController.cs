using Microsoft.AspNetCore.Mvc;

namespace MonitoringApp.Controllers
{
    public class ReviewController : BaseController
    {
        [HttpGet]
        public ActionResult<object> Review()
        {
            return DefaultRespose("Lista de reviews");
        }
    }
}

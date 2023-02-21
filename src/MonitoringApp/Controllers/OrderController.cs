using Microsoft.AspNetCore.Mvc;

namespace MonitoringApp.Controllers
{
    public class OrderController : BaseController
    {
        [HttpGet]
        public ActionResult<object> Pedidos()
        {
            return DefaultRespose("Lista de pedidos");
        }
    }
}

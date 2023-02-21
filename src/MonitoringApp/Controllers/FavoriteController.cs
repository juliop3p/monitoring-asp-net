using Microsoft.AspNetCore.Mvc;

namespace MonitoringApp.Controllers
{
    public class FavoriteController : BaseController
    {
        [HttpGet]
        public ActionResult<object> Favoritos()
        {
            return DefaultRespose("Lista de favoritos");
        }
    }
}

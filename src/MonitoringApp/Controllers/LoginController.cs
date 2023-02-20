using Microsoft.AspNetCore.Mvc;

namespace MonitoringApp.Controllers
{
    public class LoginController : BaseController
    {
        [HttpGet("session")]
        public ActionResult<object> GetSessao()
        {
            return DefaultRespose("username: juliop3p, password: 1234");
        }

        [HttpPost]
        public ActionResult<object> Login()
        {
            return DefaultRespose("Login realizado com sucesso.");
        }
    }
}

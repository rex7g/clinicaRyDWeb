using Microsoft.AspNetCore.Mvc;

namespace clinicaRyD.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

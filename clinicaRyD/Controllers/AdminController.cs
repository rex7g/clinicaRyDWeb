using Microsoft.AspNetCore.Mvc;

namespace clinicaRyD.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

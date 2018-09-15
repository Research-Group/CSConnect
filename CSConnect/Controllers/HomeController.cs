using Microsoft.AspNetCore.Mvc;

namespace CSConnect.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.message = 25;
            return View();
        }
    }
}

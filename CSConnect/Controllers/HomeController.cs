using Microsoft.AspNetCore.Mvc;

namespace CSConnect.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.message = "Hello,";
            ViewBag.submessage = "Brandon";
            return View();
        }
    }
}

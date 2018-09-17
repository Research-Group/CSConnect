using Microsoft.AspNetCore.Mvc;

namespace CSConnect.Controllers
{
    public class SharedController : Controller
    {
        // GET
        public IActionResult _Layout()
        {
            var fileName = "../images/banner.svg";
            ViewBag.file = fileName;
            return View();
        }
    }
}
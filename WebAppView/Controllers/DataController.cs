using Microsoft.AspNetCore.Mvc;

namespace WebAppView.Controllers
{
    public class DataController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult FileInfoA()
        {
            return View();
        }
        public IActionResult FileInfoB()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace WebAppView.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

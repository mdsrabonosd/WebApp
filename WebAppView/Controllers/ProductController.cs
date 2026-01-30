using Microsoft.AspNetCore.Mvc;

namespace WebAppView.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //Pass data using ViewBag
        public IActionResult Book()
        {
            string[] Booklist = {
                "Bangla",
                "English",
                "Physics"
           } ;
            ViewBag.message = "This is booklist";
            ViewBag.Mybooks = Booklist;
            return View();
        }

        //Pass data using ViewData
        public IActionResult Mobile()
        {
            string[] Mobleset =
            {
              "samsung",
              "Huaway",
              "Vivo",
              "itel",
              "Mi"
            };
            ViewData["srabon"] = Mobleset;
            return View();
        }

        //Pass data using Model Object
        public IActionResult Friute()
        {
            string[] Fruits =
            {
               "Banana",
               "Mango",
               "Apple",
               "Orenge",
               "Cool"
            };
            return View(Fruits);
        }
    }
}

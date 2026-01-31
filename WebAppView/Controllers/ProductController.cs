using Microsoft.AspNetCore.Mvc;
using WebAppView.ViewModel;

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
        public IActionResult GetData() { 

        Box box = new Box();

            List<Person> persons = new List<Person>();
            persons.Add(new Person { Id = 1 ,Name="srabon",Age=20,Country="Bangladesh"});
            persons.Add(new Person { Id = 2 ,Name="soisob",Age=20,Country="uk"});
            persons.Add(new Person { Id = 3 ,Name="Anik",Age=20,Country="japan"});

            List<Color> colurs = new List<Color>();
            colurs.Add(new Color{ id=1,Code="sdafha",Name="Gren"});
            colurs.Add(new Color{ id=2,Code="fdgdf",Name="REd"});
            colurs.Add(new Color{ id=3,Code="ghcfbvn",Name="Orenge"});

            box.id = 1;
            box.PersonList = persons;
            box.ColorList = colurs;
            return View(box);
        }
    }
}

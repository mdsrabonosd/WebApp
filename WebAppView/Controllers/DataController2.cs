using Microsoft.AspNetCore.Mvc;

namespace WebAppView.Controllers
{
    public class DataController2 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Showlog()
        {
            string folder = @"C:\temp";
            string filename = "syslog.txt";
            string fpath = Path.Join(folder, filename);
            string[] lines=System.IO.File.ReadAllLines(fpath);
            return View(lines);
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace WebAppView.Controllers
{
    public class DataController2 : Controller
    {
        public IActionResult Index()
        {
            string folder = @"C:\temp";
            string filename = "syslog.txt";
            string fpath = Path.Join(folder, filename);
            string[] lines = System.IO.File.ReadAllLines(fpath);
            ViewBag.color = "bg-primary";
            ViewBag.msg = "show log file from Index";
            return View("Showlog",lines);
            
        }
        public IActionResult Showlog()
        {
            string folder = @"C:\temp";
            string filename = "syslog.txt";
            string fpath = Path.Join(folder, filename);
            string[] lines=System.IO.File.ReadAllLines(fpath);
            ViewBag.color = "bg-danger";

            ViewBag.msg = "show log file from Showlog";

            return View(lines);
        }
    }
}

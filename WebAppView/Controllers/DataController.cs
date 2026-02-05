using Microsoft.AspNetCore.Mvc;
using WebAppView.ViewModel;

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

        //show the File information  using Model
        public IActionResult FileInfoInfo()
        {
            int i = 1;
            var folder = @"C:\Users\user\Documents\Materials";
            string[] files = Directory.GetFiles(folder);

            List<FileInformation> list = new List<FileInformation>();
            foreach (string item in files)
            {
                FileInformation Finfo = new FileInformation();
                Finfo.Id = i;
                Finfo.FileName=Path.GetFileNameWithoutExtension(item);
                Finfo.FileExtention=Path.GetExtension(item);
                Finfo.FilePath = item;
                Finfo.Filesize = new FileInfo(item).Length;
                list.Add(Finfo);
                i++;
            }
            
            return View(list);
        }
    }
}

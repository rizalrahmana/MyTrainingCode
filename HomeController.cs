using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using TrainingCore.Models;

namespace TrainingCore.Controllers
{
    public class HomeController : Controller
    {
        private static IHostingEnvironment  _hostingEnvironment { get; set; }
        //private IHostingEnvironment _hostingEnvironment;
        private string projectRootFolder;
        public HomeController(IHostingEnvironment env)
        {
            //_env = env; 
            _hostingEnvironment = env;
            projectRootFolder = env.ContentRootPath;
        }
        //private string webRoot = _env.ContentRootPath;
        //private string file = Path.Combine(_env.ContentRootPath, "Owners.txt");
        private static void Gaut()
        {
            
        }
        public IActionResult Index()
        {
            var pathToData = Path.GetFullPath(Path.Combine(_hostingEnvironment.ContentRootPath, "Owners.txt"));
            //var pathToData = Path.GetFullPath(Path.Combine(projectRootFolder, "Owners.txt"));
            //var aa = System.IO.File.ReadAllLines(Path.GetFullPath(Path.Combine(projectRootFolder, "Owners.txt")));
            //string a = System.IO.File.ReadAllLines(file);
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

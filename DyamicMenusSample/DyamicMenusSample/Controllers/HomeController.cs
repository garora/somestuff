using DyamicMenusSample.Models;
using DyamicMenusSample.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace DyamicMenusSample.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMenuService _menu;
        private readonly ILogger<HomeController> _logger;


        public HomeController(ILogger<HomeController> logger, IMenuService menu)
        {
            _logger = logger;
            _menu = menu;
        }

        public IActionResult Index()
        {
            //This is the simplest approach to get dynamic data 
            //other approaches would be: to persist values within user specific sessions
            //where navigation would require user specific.
            ViewData["menu"] = _menu.BuildMenus();
            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult About()
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

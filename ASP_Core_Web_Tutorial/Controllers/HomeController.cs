using System.Diagnostics;
using ASP_Core_Web_Tutorial.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP_Core_Web_Tutorial.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //https://localhost:5001/Home/Index
        public IActionResult Index()
        {
            return View();
        }

        //https://localhost:5001/Home/Privacy
        public IActionResult Privacy()
        {
            return View();
        }

        //https://localhost:5001/Home/Biplab
        public IActionResult Biplab()
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

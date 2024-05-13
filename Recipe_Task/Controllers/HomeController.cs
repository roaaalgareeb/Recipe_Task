using Microsoft.AspNetCore.Mvc;
using Recipe_Task.Models;
using System.Diagnostics;

namespace Recipe_Task.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
        public IActionResult contact()
        {
            return View();
        }
        public IActionResult Arabic_Recipes()
        {
            return View();
        }
        public IActionResult Recipes_Details()
        {
            return View();
        }


        public IActionResult Testimonial()
        {
            return View();
        }
        public IActionResult HomeChef()
        {
            return View();
        }
        public IActionResult AddRecipe()
        {
            return View();
        }
        public IActionResult HomeUser()
        {
            return View();
        }
        public IActionResult Recipe()
        {
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

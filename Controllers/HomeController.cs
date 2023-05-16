using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

using projet.Models;


namespace projet.Controllers
{
    public class HomeController : Controller
    {
        
        private readonly ILogger<HomeController> _logger;

        public IActionResult RedirectToEvent()
        {
            return RedirectToAction("Index", "Event");

        }
        public IActionResult RedirectToUser()
        {
            return RedirectToAction("Index", "User");
        }
        public IActionResult RedirectToVille()
        {
            return RedirectToAction("Index", "Ville");
        }
        public IActionResult RedirectToActivite()
        {
            return RedirectToAction("Index", "Activite");
        }








        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
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
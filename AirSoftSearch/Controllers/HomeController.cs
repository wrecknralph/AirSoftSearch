using AirsoftSearch.Models;
using AirSoftSearch.Utilities;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AirsoftSearch.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(SearchModel searchModel)
        {
            string url = $"https://www.evike.com/s/?q={searchModel.SearchTerm}&x=0&y=0";
            ViewBag.EvikeLink = $"<a href=\"{url}\" target=\"_blank\">Evike.com<a>";
            ViewBag.EvikeImg = $"<a href=\"{url}\" target=\"_blank\"><img src=\"{GlobalFunctions.CreateUrlImage(url)}\" width=\"500px\" /><a>";            

            return View();
        }
        public IActionResult Index()
        {
            ViewBag.ResponseHTML = null;
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

using AirsoftSearch.Models;
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
            ViewBag.ResponseHTML = $"<a href=\"https://www.evike.com/s/?q={searchModel.SearchTerm}&x=0&y=0\" target=\"_blank\">Evike.com<a>";
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

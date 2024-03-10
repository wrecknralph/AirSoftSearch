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

            string urlRedWolf = $"https://www.redwolfairsoft.com/catalogsearch/result/?q={searchModel.SearchTerm}&x=0&y=0";
            ViewBag.RedWolfLink = $"<a href=\"{urlRedWolf}\" target=\"_blank\">RedWolfAirsoft.com<a>";
            ViewBag.RedWolfImg = $"<a href=\"{urlRedWolf}\" target=\"_blank\"><img src=\"{GlobalFunctions.CreateUrlImage(urlRedWolf)}\" width=\"500px\" /><a>";

            string urlAirsoftGi = $"https://www.airsoftgi.com/advanced_search_result.php?PLsort=1d&keywords={searchModel.SearchTerm}&x=0&y=0";
            ViewBag.AirsoftGiLink = $"<a href=\"{urlAirsoftGi}\" target=\"_blank\">AirsoftGi.com<a>";
            ViewBag.AirsoftGiImg = $"<a href=\"{urlAirsoftGi}\" target=\"_blank\"><img src=\"{GlobalFunctions.CreateUrlImage(urlAirsoftGi)}\" width=\"500px\" /><a>";

            string urlAirsoftStation = $"https://airsoftstation.com/search.php?search_query={searchModel.SearchTerm}&x=0&y=0";
            ViewBag.AirsoftStationLink = $"<a href=\"{urlAirsoftStation}\" target=\"_blank\">AirsoftStation.com<a>";
            ViewBag.AirsoftStationImg = $"<a href=\"{urlAirsoftStation}\" target=\"_blank\"><img src=\"{GlobalFunctions.CreateUrlImage(urlAirsoftStation)}\" width=\"500px\" /><a>";


            string urlAirsoftExtreme = $"https://www.airsoftextreme.com/search/ss360/?ss360Query={searchModel.SearchTerm}&x=0&y=0";
            ViewBag.AirsoftExtremeLink = $"<a href=\"{urlAirsoftExtreme}\" target=\"_blank\">AirsoftExtreme.com<a>";
            ViewBag.AirsoftExtremeImg = $"<a href=\"{urlAirsoftExtreme}\" target=\"_blank\"><img src=\"{GlobalFunctions.CreateUrlImage(urlAirsoftExtreme)}\" width=\"500px\" /><a>";

            string urlAirsoftMegaStore = $"https://www.airsoftmegastore.com/index.php?route=product%2Fsearch&search={searchModel.SearchTerm}&x=0&y=0";
            ViewBag.AirsoftMegaStoreLink = $"<a href=\"{urlAirsoftMegaStore}\" target=\"_blank\">AirsoftMegaStore.com<a>";
            ViewBag.AirsoftMegaStoreImg = $"<a href=\"{urlAirsoftMegaStore}\" target=\"_blank\"><img src=\"{GlobalFunctions.CreateUrlImage(urlAirsoftMegaStore)}\" width=\"500px\" /><a>";
            
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

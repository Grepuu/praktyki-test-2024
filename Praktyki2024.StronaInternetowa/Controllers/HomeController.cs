using Microsoft.AspNetCore.Mvc;
using Praktyki2024.StronaInternetowa.Models;
using System;
using System.Diagnostics;
using System.Reflection;

namespace Praktyki2024.StronaInternetowa.Controllers
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

        [Route("informacje-o-mnie")]
        public IActionResult About()
        {
            return View();
        }

        [Route("samochod/detale")]
        public IActionResult CarDetails()
        {
            // dane o samochodzie
            var daneSamochod = new CarDetailsViewModel(
                "Mercedes",
                "Z³oty",
                12000,
                false,
                43400
            );

            return View(daneSamochod);
        }

        [Route("samochody-statystyki")]
        public IActionResult CarStats()
        {
            // statystyki samochodów w systemie
            var statystyki = new CarStatsViewModel(
                12,
                13,
                14,
                15,
                16
            );
            return View(statystyki);
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

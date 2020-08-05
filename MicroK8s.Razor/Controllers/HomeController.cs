using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MicroK8s.Razor.Models;
using System.Runtime.CompilerServices;
using MicroK8s.Razor.Messages;

namespace MicroK8s.Razor.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICountryUpdateSender _countryUpdateSender;
        public HomeController(ILogger<HomeController> logger, ICountryUpdateSender countryUpdateSender)
        {
            _logger = logger;
            _countryUpdateSender = countryUpdateSender;
        }

        public IActionResult Index()
        {
            return View();
            
        }

        [HttpPost]
        public IActionResult Index(CountryModel model)
        {
            ViewData["Message"] = "Message Sent!";
            _countryUpdateSender.SendCountry(model);
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

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebAppPalestra.Models;
using WebAppPalestra.Factory;
using WebAppPalestra.Business;

namespace WebAppPalestra.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IFactory factory;
        private readonly RulesSheet appo;

        public HomeController(ILogger<HomeController> logger, IFactory factory, RulesSheet appo)
        {
            _logger = logger;
            this.factory = factory;
            this.appo = appo;
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

        [HttpPost]
        public IActionResult GetDto(SheetModel sheetModel)
        {
            return View(factory.FindSheet(appo.FindSheet(sheetModel)));
        }
    }
}

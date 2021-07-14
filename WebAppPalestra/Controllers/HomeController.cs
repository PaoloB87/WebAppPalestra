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

        public HomeController(ILogger<HomeController> logger, IFactory factory)
        {
            _logger = logger;
            this.factory = factory;
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

            //ASheet appoSheet;
            //appoSheet = new Sheet1();
            //return View(appoSheet);

            RulesSheet appo = new RulesSheet();

            return View(factory.FindSheet(appo.FindSheet(sheetModel)));
            //return View(factory.FindSheet(RulesSheet.FindSheet(sheetModel)));

        }
    }
}

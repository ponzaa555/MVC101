using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mvc101.Models;

namespace mvc101.Controllers
{
    public class Items : Controller
    {
        private readonly ILogger<Items> _logger;

        public Items(ILogger<Items> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Overview()
        {
            var item = new Item(){
                NAME = "keyboard"
            };
            return View( item);
        }
        public IActionResult Edit(int id)
        {
            return Content("id="+id);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}
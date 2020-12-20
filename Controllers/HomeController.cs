﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SharpCodeWebsite.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SharpCodeWebsite.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Services()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Course()
        {
            return View();
        }
        public IActionResult Front()
        {
            return View();
        }
        public IActionResult Mobile()
        {
            return View();
        }
        
        public IActionResult All()
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

﻿using Microsoft.AspNetCore.Mvc;
using SD115Demos.Models;
using System.Diagnostics;
using System.Net.Security;

namespace SD115Demos.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private string _person = "Juan Alberto Hernandez";

        public string Person { get { return _person; } }
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        

        

        public IActionResult Index()
        {
            return View("Index");
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
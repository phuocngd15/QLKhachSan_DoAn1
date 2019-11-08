﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HappyHoTel.Models;

namespace HappyHoTel.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {
     
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
    }
}

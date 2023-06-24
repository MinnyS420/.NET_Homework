﻿using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.Models;
using System.Diagnostics;

namespace SEDC.PizzaApp.Controllers
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

        public IActionResult Contact() 
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
        public IActionResult SeeUsers()
        {
            var users = StaticDb.Users.Select(user => $"{user.FirstName} {user.LastName}").ToList();
            return View(users);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
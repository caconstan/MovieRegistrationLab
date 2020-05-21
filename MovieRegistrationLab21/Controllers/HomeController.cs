using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovieRegistrationLab21.Models;

namespace MovieRegistrationLab21.Controllers
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

        public IActionResult RegisterMovie()
        {
            return View();
        }

        public IActionResult EditMovie(MovieModel mm)
        {
           return View("RegisterMovie", mm);
        }

        public IActionResult RegisterMovieSummary(MovieModel mm)
        {
            if (ModelState.IsValid )
            {
                return View(mm);
            } else
            {
                return View("RegisterMovie", mm);
            }
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

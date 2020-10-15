using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using IPL.Models;

namespace IPL.Controllers
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
            Random r = new Random();
            int team1Index = r.Next(0, 7);
            int team2Index = r.Next(0, 7); 
            string[] teams = { "Chennai Super Kings", "Mumbai Indians", "Kolkata Knight Riders", "Royal Challengers Banglore", "Delhi Capitals", "Sunrisers Hyderabad", "Rajasthan Royals", "King XI Punjab"};
            var vm = new TeamModel()
            {
                TeamName1 = teams[team1Index],
                Overs1 = 0.0m,
                Runs1 = 132,
                Wickets1 = 0,

                TeamName2 = teams[team2Index],
                Overs2 = 0.0m,
                Runs2 = 0,
                Wickets2 = 0


            };
            return View("Index",vm);
        }

        public IActionResult Teams()
        {
            return View();
        }

        public IActionResult NextOver()
        {
            TempData["buttonVal"] = "Next Over triggered";
            
            return RedirectToAction("Index");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

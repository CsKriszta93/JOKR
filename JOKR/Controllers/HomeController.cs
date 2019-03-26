using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using JOKR.Models;
using GameStore.DAL;
using BLL.Service;
using BLL.Mapper;

namespace JOKR.Controllers
{
    public class HomeController : Controller
    {
        GameService gameservice;

        public HomeController()
        {
            gameservice = new GameService(new ApplicationDbContext(), new GameMappingProfile());
        }

        public IActionResult Index()
        {
            ViewData["Users"] = gameservice.GetGames();

            return View();
        }

        /*public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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
        }*/
    }
}

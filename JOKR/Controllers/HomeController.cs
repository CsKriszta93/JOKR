using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using JOKR.Models;
using JOKR.Data;
using JOKR.Service;
using JOKR.ServiceInterfaces;
using BLL.Mapper;
using AutoMapper;
using AutoMapper.QueryableExtensions;

namespace JOKR.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGameService gameService;
        private readonly IMapper mapper;

        public HomeController(IGameService gameService, IMapper mapper)
        {
            this.gameService = gameService;
            this.mapper = mapper;
        }

        public IActionResult Index()
        {
            ViewData["Users"] = mapper.Map<IEnumerable<BLL.Dtos.GameDto>, IEnumerable<GameView>>(source: gameService.GetGames().Result);

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

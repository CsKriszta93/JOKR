﻿using System;
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

        public async Task<IActionResult> Index()
        {
            var gameDtos = await gameService.GetGames();     
            var games = gameDtos.Select(x => mapper.Map<GameView>(x));
            

            return View(games);
        }

        public async Task<IActionResult> GameView(Guid id)
        {
            var gameDto = await gameService.GetGame(id);
            var game = mapper.Map<GameView>(gameDto);
            System.Diagnostics.Debug.WriteLine(game.GameName);
  
            return View(game);
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

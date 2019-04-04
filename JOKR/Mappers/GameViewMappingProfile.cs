using AutoMapper;
using JOKR.Models;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JOKR.Mappers
{
    public class GameViewMappingProfile : Profile
    {
        public GameViewMappingProfile()
        {
            CreateMap<GameView, Game>().ReverseMap();
        }
    }
}


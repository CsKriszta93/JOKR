using AutoMapper;
using AutoMapper.QueryableExtensions;
using BLL.Dtos;
using BLL.Mapper;
using JOKR.ServiceInterfaces;
using Entities;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace JOKR.Service
{
    public class GameService : IGameService
    {
        private readonly ApplicationDbContext dbContext;
        private readonly IMapper mapper;

        public GameService(ApplicationDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<GameDto>> GetGames()
        {
            var games = await dbContext
                .Games
                .ProjectTo<GameDto>(mapper.ConfigurationProvider)
                .ToListAsync();

            return games;
        }
    }
}

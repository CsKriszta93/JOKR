using AutoMapper.QueryableExtensions;
using BLL.Dtos;
using BLL.Mapper;
using BLL.ServiceInterfaces;
using GameStore.DAL;
using Model;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace BLL.Service
{
    public class GameService : IGameService
    {
        private readonly ApplicationDbContext dbContext;
        private readonly GameMappingProfile mapper;

        public GameService(ApplicationDbContext dbContext, GameMappingProfile mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<GameDto>> GetGames()
        {
            var games = await dbContext
                .Games
                .ProjectTo<GameDto>()
                .ToListAsync();

            return games;
        }
    }
}

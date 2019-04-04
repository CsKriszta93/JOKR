using BLL.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JOKR.ServiceInterfaces
{
    public interface IGameService
    {
        Task<IEnumerable<GameDto>> GetGames();
        Task<GameDto> GetGame(System.Guid id);
    }
}

using BLL.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL.ServiceInterfaces
{
    public interface IGameService
    {
        Task<IEnumerable<GameDto>> GetGames();
    }
}

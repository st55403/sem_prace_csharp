using System.Collections.Generic;
using System.Threading.Tasks;
using WpfApp1.Services.API.Models;

namespace WpfApp1.Services
{
    public interface ISpaceXService
    {
        Task<IEnumerable<ParsedLaunch>> GetAllLaunches();
        Task<IEnumerable<ParsedShip>> GetAllShips();
    }
}

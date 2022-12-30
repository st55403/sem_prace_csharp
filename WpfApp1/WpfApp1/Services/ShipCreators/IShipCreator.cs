using System.Threading.Tasks;
using WpfApp1.Models;

namespace WpfApp1.Services.ShipCreators
{
    public interface IShipCreator
    {
        Task CreateShip(Ship ship);
    }
}

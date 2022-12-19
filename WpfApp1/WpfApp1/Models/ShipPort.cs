using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Services.ShipCreators;
using WpfApp1.Services.ShipProviders;

namespace WpfApp1.Models
{
    public class ShipPort
    {
        private readonly IShipProvider shipProvider;
        private readonly IShipCreator shipCreator;

        public ShipPort(IShipProvider shipProvider, IShipCreator shipCreator)
        {
            this.shipProvider = shipProvider;
            this.shipCreator = shipCreator;
        }

        public async Task<IEnumerable<Ship>> GetAllShips()
        {
            return await shipProvider.GetAllShips();
        }

        public async Task AddShip(Ship ship)
        {
            await shipCreator.CreateShip(ship);
        }
    }
}

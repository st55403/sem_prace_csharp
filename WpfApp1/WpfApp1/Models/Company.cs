using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Models
{
    public class Company
    {
        private readonly RocketGarage _rocketGarage;
        private readonly ShipPort _shipPort;

        public string Name { get; }

        public Company(string name, RocketGarage rocketGarage, ShipPort shipPort)
        {
            Name = name;

            _rocketGarage = rocketGarage;
            _shipPort = shipPort;
        }

        public async Task<IEnumerable<Rocket>> GetAllRockets()
        {
            return await _rocketGarage.GetAllRockets();
        }

        public async Task AddRocket(Rocket rocket)
        {
            _rocketGarage.AddRocket(rocket);
        }

        public async Task<IEnumerable<Ship>> GetAllShips()
        {
            return await _shipPort.GetAllShips();
        }

        public async Task AddShip(Ship ship)
        {
            _shipPort.AddShip(ship);
        }
    }
}

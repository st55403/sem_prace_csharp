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
        private readonly LaunchRecords _launchRecords;

        public string Name { get; }

        public Company(string name, RocketGarage rocketGarage, ShipPort shipPort, LaunchRecords launchRecords)
        {
            Name = name;

            _rocketGarage = rocketGarage;
            _shipPort = shipPort;
            _launchRecords = launchRecords;
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

        public async Task<IEnumerable<Launch>> GetAllLaunches()
        {
            return await _launchRecords.GetAllLaunches();
        }

        public async Task AddLaunch(Launch launch)
        {
            _launchRecords.AddLaunch(launch);
        }
    }
}

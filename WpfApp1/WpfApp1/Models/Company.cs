using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WpfApp1.Services;
using WpfApp1.Services.API;

namespace WpfApp1.Models
{
    public class Company
    {
        private readonly RocketGarage _rocketGarage;
        private readonly ShipPort _shipPort;
        private readonly LaunchRecords _launchRecords;
        private readonly SpaceXService _spaceXService;

        public string Name { get; }

        public Company(string name, RocketGarage rocketGarage, ShipPort shipPort, LaunchRecords launchRecords, ISpaceXService spaceXService)
        {
            Name = name;

            _rocketGarage = rocketGarage;
            _shipPort = shipPort;
            _launchRecords = launchRecords;
            _spaceXService = (SpaceXService?)spaceXService;
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

        public async Task UpdateLaunch(Launch launch)
        {
            _launchRecords.UpdateLaunch(launch); ;
        }

        public async void FetchDataFromSpaceXServiceAndChachLocally()
        {
            var launches = await _spaceXService.GetAllLaunches();
            foreach (var launch in launches)
            {
                //Trace.WriteLine(launch.ToString());
                _rocketGarage.AddRocket(new Rocket(
                    launch.rocket_name,
                    launch.rocket_id,
                    new Engine(1, launch.rocket_type)
                    ));
                _launchRecords.AddLaunch(new Launch(
                    launch.details,
                    launch.flight_number.ToString(),
                    launch.launch_date_utc,
                    launch.launch_success.ToString(),
                    launch.mission_name,
                    launch.upcoming.ToString()
                    ));
            }

            var ships = await _spaceXService.GetAllShips();
            foreach (var ship in ships)
            {
                foreach (var mission in ship.missions)
                {
                    Trace.WriteLine(mission.flight + " lol " + ship.ship_id);
                    _launchRecords.AddLaunchShipRelation(new LaunchShip()
                    {
                        ShipId = ship.ship_id,
                        FlightNumber = mission.flight.ToString(),
                    });
                }
                //Trace.WriteLine(ship.ToString());
                var shipMissionName = "";
                if (ship.missions.Count > 0)
                {
                    shipMissionName = ship.missions.First().name;
                } else
                {
                    shipMissionName = "";
                }
                _shipPort.AddShip(new Ship(
                    ship.ship_id.ToString(),
                    ship.home_port,
                    ship.year_built.ToString(),
                    ship.status,
                    shipMissionName
                    ));
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.DbContexts;
using WpfApp1.DTOs;
using WpfApp1.Models;

namespace WpfApp1.Services.ShipCreators
{
    public class DatabaseShipCreator : IShipCreator
    {
        private readonly SpaceXDbContextFactory spaceXDbContextFactory;

        public DatabaseShipCreator(SpaceXDbContextFactory spaceXDbContextFactory)
        {
            this.spaceXDbContextFactory = spaceXDbContextFactory;
        }

        public async Task CreateShip(Ship ship)
        {
            using (SpaceXDbContext context = spaceXDbContextFactory.CreateDbContext())
            {
                ShipDTO shipDTO = new ShipDTO() { ShipId = ship.ShipId, HomePort = ship.HomePort, YearOfBuild = ship.YearOfBuild, Status = ship.Status, Mission = ship.Mission };

                context.Ships.Add(shipDTO);
                await context.SaveChangesAsync();
            }
        }
    }
}

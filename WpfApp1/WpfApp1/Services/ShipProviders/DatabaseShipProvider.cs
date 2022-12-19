using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.DbContexts;
using WpfApp1.DTOs;
using WpfApp1.Models;

namespace WpfApp1.Services.ShipProviders
{
    public class DatabaseShipProvider : IShipProvider
    {
        private readonly SpaceXDbContextFactory spaceXDbContextFactory;

        public DatabaseShipProvider(SpaceXDbContextFactory spaceXDbContextFactory)
        {
            this.spaceXDbContextFactory = spaceXDbContextFactory;
        }

        public async Task<IEnumerable<Ship>> GetAllShips()
        {
            using (SpaceXDbContext context = spaceXDbContextFactory.CreateDbContext())
            {
                IEnumerable<ShipDTO> shipDTO = await context.Ships.ToListAsync();
                return shipDTO.Select(s => new Ship(s.ID, s.HomePort, s.YearOfBuild, s.Status, s.Mission));
            }
        }
    }
}

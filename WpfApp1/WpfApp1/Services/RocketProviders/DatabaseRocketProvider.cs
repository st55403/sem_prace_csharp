using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.DbContexts;
using WpfApp1.DTOs;
using WpfApp1.Models;

namespace WpfApp1.Services.RocketProviders
{
    public class DatabaseRocketProvider : IRocketProvider
    {
        private readonly SpaceXDbContextFactory spaceXDbContextFactory;

        public DatabaseRocketProvider(SpaceXDbContextFactory spaceXDbContextFactory)
        {
            this.spaceXDbContextFactory = spaceXDbContextFactory;
        }

        public async Task<IEnumerable<Rocket>> GetAllRockets()
        {
            using(SpaceXDbContext context = spaceXDbContextFactory.CreateDbContext())
            {
                IEnumerable<RocketDTO> rocketDTOs = await context.Rockets.ToListAsync();
                return rocketDTOs.Select(r => new Rocket(r.RocketName, r.RocketID, new Engine(r.EngineNumber, r.EngineType)));
            }
        }
    }
}

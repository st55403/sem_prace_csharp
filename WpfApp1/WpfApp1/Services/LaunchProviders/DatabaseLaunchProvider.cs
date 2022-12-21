using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.DbContexts;
using WpfApp1.DTOs;
using WpfApp1.Models;

namespace WpfApp1.Services.LaunchProviders
{
    public class DatabaseLaunchProvider : ILaunchProvider
    {
        private readonly SpaceXDbContextFactory spaceXDbContextFactory;

        public DatabaseLaunchProvider(SpaceXDbContextFactory spaceXDbContextFactory)
        {
            this.spaceXDbContextFactory = spaceXDbContextFactory;
        }

        public async Task<IEnumerable<Launch>> GetAllLaunches()
        {
            using (SpaceXDbContext context = spaceXDbContextFactory.CreateDbContext())
            {
                IEnumerable<LaunchDTO> launchDTO = await context.Launches.ToListAsync();
                return launchDTO.Select(l => new Launch(l.Details, l.FlightNumber, l.LaunchDateUtc, l.LaunchSuccess, l.MissionName, l.Upcoming));
            }
        }
    }
}

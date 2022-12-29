using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.DbContexts;
using WpfApp1.DTOs;
using WpfApp1.Models;

namespace WpfApp1.Services.LaunchCreators
{
    public class DatabaseLaunchCreator : ILaunchCreator
    {
        private readonly SpaceXDbContextFactory spaceXDbContextFactory;

        public DatabaseLaunchCreator(SpaceXDbContextFactory spaceXDbContextFactory)
        {
            this.spaceXDbContextFactory = spaceXDbContextFactory;
        }

        public async Task AddLaunch(Launch l)
        {
            using (SpaceXDbContext context = spaceXDbContextFactory.CreateDbContext())
            {
                LaunchDTO launchDTO = new LaunchDTO() { Details = l.Details , FlightNumberId = l.FlightNumber, LaunchDateUtc = l.LaunchDateUtc, LaunchSuccess = l.LaunchSuccess, MissionName = l.MissionName, Upcoming = l.Upcoming};
                context.Launches.Add(launchDTO);
                await context.SaveChangesAsync();
            }
        }

        public async Task UpdateLaunch(Launch l)
        {
            using (SpaceXDbContext context = spaceXDbContextFactory.CreateDbContext())
            {
                LaunchDTO launchDTO = new LaunchDTO() { Details = l.Details, FlightNumberId = l.FlightNumber, LaunchDateUtc = l.LaunchDateUtc, LaunchSuccess = l.LaunchSuccess, MissionName = l.MissionName, Upcoming = l.Upcoming };
                context.Launches.Update(launchDTO);
                await context.SaveChangesAsync();
            }
        }
    }
}

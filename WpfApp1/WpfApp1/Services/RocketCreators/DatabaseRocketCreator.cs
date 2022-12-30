using System.Threading.Tasks;
using WpfApp1.DbContexts;
using WpfApp1.DTOs;
using WpfApp1.Models;

namespace WpfApp1.Services.RocketCreators
{
    public class DatabaseRocketCreator : IRocketCreator
    {
        private readonly SpaceXDbContextFactory spaceXDbContextFactory;

        public DatabaseRocketCreator(SpaceXDbContextFactory spaceXDbContextFactory)
        {
            this.spaceXDbContextFactory = spaceXDbContextFactory;
        }

        public async Task CreateRocket(Rocket rocket)
        {
            using(SpaceXDbContext context = spaceXDbContextFactory.CreateDbContext())
            {
                RocketDTO rocketDTO = new RocketDTO() { RocketName = rocket.RocketName, RocketID = rocket.RocketID, EngineNumber = rocket.engine.Number, EngineType = rocket.engine.Type };

                context.Rockets.Add(rocketDTO);
                await context.SaveChangesAsync();
            }
        }
    }
}

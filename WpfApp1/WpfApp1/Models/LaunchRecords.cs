using System.Collections.Generic;
using System.Threading.Tasks;
using WpfApp1.Services.LaunchCreators;
using WpfApp1.Services.LaunchProviders;

namespace WpfApp1.Models
{
    public class LaunchRecords
    {
        private readonly ILaunchProvider launchProvider;
        private readonly ILaunchCreator launchCreator;

        public LaunchRecords(ILaunchProvider launchProvider, ILaunchCreator launchCreator)
        {
            this.launchProvider = launchProvider;
            this.launchCreator = launchCreator;
        }

        public async Task<IEnumerable<Launch>> GetAllLaunches()
        {
            return await launchProvider.GetAllLaunches();
        }

        public async Task AddLaunch(Launch launch)
        {
            await launchCreator.AddLaunch(launch);
        }

        public async Task UpdateLaunch(Launch launch)
        {
            await launchCreator.UpdateLaunch(launch);
        }

        public async Task AddLaunchShipRelation(LaunchShip launchShip)
        {
            await launchCreator.AddLaunchShip(launchShip);
        }
    }
}

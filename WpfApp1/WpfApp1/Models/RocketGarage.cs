using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Services.RocketCreators;
using WpfApp1.Services.RocketProviders;

namespace WpfApp1.Models
{
    public class RocketGarage
    {
        private readonly IRocketProvider rocketProvider;
        private readonly IRocketCreator rocketCreator;

        public RocketGarage(IRocketProvider rocketProvider, IRocketCreator rocketCreator)
        {
            this.rocketProvider = rocketProvider;
            this.rocketCreator = rocketCreator;
        }

        public async Task<IEnumerable<Rocket>> GetAllRockets()
        {
            return await rocketProvider.GetAllRockets();
        }

        public async Task AddRocket(Rocket rocket)
        {
            await rocketCreator.CreateRocket(rocket);
        }
    }
}

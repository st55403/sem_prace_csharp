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

        public string Name { get; }

        public Company(string name, RocketGarage rocketGarage)
        {
            Name = name;

            _rocketGarage = rocketGarage;
        }

        public async Task<IEnumerable<Rocket>> GetAllRockets()
        {
            return await _rocketGarage.GetAllRockets();
        }

        public async Task AddRocket(Rocket rocket)
        {
            _rocketGarage.AddRocket(rocket);
        }
    }
}

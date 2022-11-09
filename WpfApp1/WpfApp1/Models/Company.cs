using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Models
{
    class Company
    {
        private readonly RocketGarage _rocketGarage;

        public string Name { get; }

        public Company(string name)
        {
            Name = name;

            _rocketGarage = new RocketGarage();
        }

        public List<Rocket> GetAllRockets()
        {
            return _rocketGarage.GetAllRockets();
        }

        public void AddRocket(Rocket rocket)
        {
            _rocketGarage.AddRocket(rocket);
        }
    }
}

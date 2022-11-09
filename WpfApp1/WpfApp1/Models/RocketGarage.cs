using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Models
{
    class RocketGarage
    {
        private readonly List<Rocket> _rockets;

        public RocketGarage()
        {
            _rockets = new List<Rocket>();
        }

        public List<Rocket> GetAllRockets()
        {
            return _rockets;
        }

        public void AddRocket(Rocket rocket)
        {
            _rockets.Add(rocket);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Models
{
    public class Rocket
    {
        public string Company { get; set; }
        public string CostPerLaunch { get; set; }
        public string Country { get; set; }
        public string Description { get; set; }
        public string RocketName { get; set; }

        public Rocket(string company, string costPerLaunch, string country, string description, string rocketName)
        {
            Company = company;
            CostPerLaunch = costPerLaunch;
            Country = country;
            Description = description;
            RocketName = rocketName;
        }

        public override string? ToString()
        {
            return String.Format("Rocket with name {0} has been made in {1} under company {2} with a price per launch {3}",
                RocketName, Country, Company, CostPerLaunch);

        }
    }
}

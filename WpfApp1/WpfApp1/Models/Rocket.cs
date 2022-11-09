using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Models
{
    public class Rocket
    {
        public string RocketName { get; set; }
        public string RocketID { get; set; }
        public Engine engine { get; set; }

    }

    public class Engine
    {
        public int Number { get; set; }
        public string Type { get; set; }

        public Engine(int number, string type)
        {
            Number = number;
            Type = type;
        }
    }
}

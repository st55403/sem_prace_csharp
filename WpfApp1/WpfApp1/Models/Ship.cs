using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Models
{
   public class Ship
    {
        public string ID { get; set; }
        public string HomePort { get; set; }
        public string YearOfBuild { get; set; }

        public string Status { get; set; }

        public string Mission { get; set; }

        public Ship(string iD, string homePort, string yearOfBuild, string status, string mission)
        {
            ID = iD;
            HomePort = homePort;
            YearOfBuild = yearOfBuild;
            Status = status;
            Mission = mission;
        }
    }
}

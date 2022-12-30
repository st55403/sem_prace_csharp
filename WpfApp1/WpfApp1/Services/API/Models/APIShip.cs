using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Services.API.Models
{
    public class APIShip
    {
        public string ship_id { get; set; }
        public string home_port { get; set; }
        public int? year_built { get; set; }
        public string status { get; set; }
        public List<Mission> missions { get; set; }
    }

    public class Mission
    {
        public string name { get; set; }
        public int flight { get; set; }
    }
}

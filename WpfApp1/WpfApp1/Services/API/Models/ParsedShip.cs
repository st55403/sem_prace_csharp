using System.Collections.Generic;

namespace WpfApp1.Services.API.Models
{
    public class ParsedShip
    {
        public string ship_id { get; set; }
        public string home_port { get; set; }
        public int? year_built { get; set; }
        public string status { get; set; }
        public List<Mission> missions { get; set; }
    }
}

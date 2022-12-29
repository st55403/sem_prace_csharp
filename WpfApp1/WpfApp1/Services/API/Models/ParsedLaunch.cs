using System.Collections.Generic;

namespace WpfApp1.Services.API.Models
{
    public class ParsedLaunch
    {
        public int flight_number { get; set; }
        public string mission_name { get; set; }
        public bool? upcoming { get; set; }
        public string launch_date_utc { get; set; }
        public bool? launch_success { get; set; }
        public string details { get; set; }
        public string rocket_id { get; set; }
        public string rocket_name { get; set; }
        public string rocket_type { get; set; }
    }
}
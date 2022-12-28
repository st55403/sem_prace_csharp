using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Services.API.Models
{
    public class APILaunch
    {
        public int flight_number { get; set; }
        public string mission_name { get; set; }
        // todo consider to resolve those booleans sometimes they have wired values there
        public object upcoming { get; set; }
        public string launch_date_utc { get; set; }
        // todo consider to resolve those booleans sometimes they have wired values there
        public object launch_success { get; set; }
        public string details { get; set; }

        // todo add here other prop such as rockets and ships
    }
}

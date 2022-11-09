using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Models
{
    public class Launch
    {
        public string Details { get; set; }
        public string FlightNumber { get; set; }
        public string LaunchDateUtc { get; set; }
        public string LaunchSuccess { get; set; }
        public string MissionName { get; set; }
        public string Upcoming { get; set; }

        public Launch(string details, string flightNumber, string launchDateUtc, string launchSuccess, string missionName, string upcoming)
        {
            Details = details;
            FlightNumber = flightNumber;
            LaunchDateUtc = launchDateUtc;
            LaunchSuccess = launchSuccess;
            MissionName = missionName;
            Upcoming = upcoming;
        }

        public override string? ToString()
        {
            return String.Format("Flight has number {0} with name {1} launched on {2}",
                FlightNumber, MissionName, LaunchDateUtc);
        }
    }
}

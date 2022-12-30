using WpfApp1.Models;

namespace WpfApp1.ViewModels
{
    public class LaunchViewModel : ViewModelBase
    {
        private Launch launch;

        public string Details => launch.Details;
        public string FlightNumber => launch.FlightNumber;
        public string LaunchDateUtc => launch.LaunchDateUtc;
        public string LaunchSuccess => launch.LaunchSuccess;
        public string MissionName => launch.MissionName;
        public string Upcoming => launch.Upcoming;

        public LaunchViewModel(Launch launch)
        {
            this.launch = launch;
        }
    }
}

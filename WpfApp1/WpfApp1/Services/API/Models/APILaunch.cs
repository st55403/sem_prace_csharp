namespace WpfApp1.Services.API.Models
{
    public class APILaunch
    {
        public int flight_number { get; set; }
        public string mission_name { get; set; }
        public bool? upcoming { get; set; }
        public string launch_date_utc { get; set; }
        public bool? launch_success { get; set; }
        public string details { get; set; }
        public Rocket rocket { get; set; }
    }

    public class Rocket
    {
        public string rocket_id { get; set; }
        public string rocket_name { get; set; }
        public string rocket_type { get; set; }
    }
}

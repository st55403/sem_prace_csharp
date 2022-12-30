using System.ComponentModel.DataAnnotations;

namespace WpfApp1.DTOs
{
    public class LaunchDTO
    {
        [Key]
        public string FlightNumberId { get; set; }
        public string Details { get; set; }
        public string LaunchDateUtc { get; set; }
        public string LaunchSuccess { get; set; }
        public string MissionName { get; set; }
        public string Upcoming { get; set; }

    }
}

using Microsoft.EntityFrameworkCore;

namespace WpfApp1.DTOs
{
    [Keyless]
    public class LaunchShipDTO
    {
        public string ShipId { get; set; }
        public string FlightNumber { get; set; }
    }
}

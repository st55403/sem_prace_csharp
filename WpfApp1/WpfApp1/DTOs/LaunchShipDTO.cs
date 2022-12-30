using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.DTOs
{
    [Keyless]
    public class LaunchShipDTO
    {
        public string ShipId { get; set; }
        public string FlightNumber { get; set; }
    }
}

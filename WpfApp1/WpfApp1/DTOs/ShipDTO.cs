using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.DTOs
{
    public class ShipDTO
    {
        [Key]
        public Guid Id { get; set; }
        public string ShipId { get; set; }
        public string HomePort { get; set; }
        public string YearOfBuild { get; set; }
        public string Status { get; set; }
        public string Mission { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace WpfApp1.DTOs
{
    public class ShipDTO
    {
        [Key]
        public string ShipId { get; set; }
        public string HomePort { get; set; }
        public string YearOfBuild { get; set; }
        public string Status { get; set; }
        public string Mission { get; set; }
    }
}

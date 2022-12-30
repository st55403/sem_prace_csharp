using System.ComponentModel.DataAnnotations;

namespace WpfApp1.DTOs
{
    public class RocketDTO
    {
        [Key]
        public string RocketID { get; set; }
        public string RocketName { get; set; }
        public int EngineNumber { get; set; }
        public string EngineType { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.DTOs
{
    public class RocketDTO
    {
        [Key]
        public Guid Id { get; set; }
        public string RocketName { get; set; }
        public string RocketID { get; set; }
        public int EngineNumber { get; set; }
        public string EngineType { get; set; }
    }
}

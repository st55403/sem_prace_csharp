using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.DTOs;
using WpfApp1.Models;

namespace WpfApp1.DbContexts
{
    public class SpaceXDbContext : DbContext
    {
        public SpaceXDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<RocketDTO> Rockets { get; set; }
    }
}

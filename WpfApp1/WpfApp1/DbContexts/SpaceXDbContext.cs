using Microsoft.EntityFrameworkCore;
using WpfApp1.DTOs;

namespace WpfApp1.DbContexts
{
    public class SpaceXDbContext : DbContext
    {
        public SpaceXDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<RocketDTO> Rockets { get; set; }

        public DbSet<ShipDTO> Ships { get; set; }

        public DbSet<LaunchDTO> Launches { get; set; }

        public DbSet<LaunchShipDTO> LaunchToShip { get; set; }
    }
}

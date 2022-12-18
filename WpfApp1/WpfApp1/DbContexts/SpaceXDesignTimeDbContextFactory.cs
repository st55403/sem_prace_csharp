using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.DbContexts
{
    public class SpaceXDesignTimeDbContextFactory : IDesignTimeDbContextFactory<SpaceXDbContext>
    {
        public SpaceXDbContext CreateDbContext(string[] args)
        {
            DbContextOptions options = new DbContextOptionsBuilder().UseSqlite("Data Source=spacex.db").Options;
            return new SpaceXDbContext(options);
        }
    }
}

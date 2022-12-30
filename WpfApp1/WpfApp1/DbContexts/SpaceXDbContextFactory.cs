using Microsoft.EntityFrameworkCore;

namespace WpfApp1.DbContexts
{
    public class SpaceXDbContextFactory
    {
        private readonly object _connectionString;

        public SpaceXDbContextFactory(object connectionString)
        {
            _connectionString = connectionString;
        }

        public SpaceXDbContext CreateDbContext()
        {
            DbContextOptions options = new DbContextOptionsBuilder().UseSqlite((string?)_connectionString).Options;
            return new SpaceXDbContext(options);
        }
    }
}

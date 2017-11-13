using Microsoft.EntityFrameworkCore;

namespace Data.Persistence
{
    public class DatabaseContext : DbContext, IDatabaseService
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) 
        {
        }

        public DbSet<City> Cities { get; set; }
    }
}

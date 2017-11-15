using Data.Domain;
using Microsoft.EntityFrameworkCore;

namespace Data.Persistance
{
    public sealed class DatabaseContext : DbContext, IDatabaseContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Poi> Pois { get; set; }
    }
}

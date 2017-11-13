using Data.Persistance;
using Microsoft.EntityFrameworkCore;

namespace Data.Persistance
{
    public class DataBaseContext : DbContext, IDatabaseService
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {
        }

        public DbSet<City> Cities { get; set; }
        

    }
}

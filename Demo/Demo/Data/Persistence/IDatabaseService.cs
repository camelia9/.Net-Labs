using Microsoft.EntityFrameworkCore;

namespace Data.Persistence
{
    public interface IDatabaseService
    {
        DbSet<City> Cities { get; set; }
        int SaveChanges();
    }
}
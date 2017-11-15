using Data.Domain;
using Microsoft.EntityFrameworkCore;

namespace Data.Persistance
{
    public interface IDatabaseContext
    {
        DbSet<Poi> Pois { get; set; }
        int SaveChanges();
    }
}

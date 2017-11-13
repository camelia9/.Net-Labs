using Data.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Persistence {
    public interface IDatabaseContext {
        DbSet<Organization> Organizations { get; set; }
        DbSet<User> Users { get; set; }
        int SaveChanges();
    }
}
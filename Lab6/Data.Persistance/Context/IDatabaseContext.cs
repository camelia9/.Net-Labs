using Data.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Persistance.Context
{
    public interface IDatabaseContext
    {
        DbSet<Organisation> Organisations { set; get; }
        int SaveChanges();
    }
}
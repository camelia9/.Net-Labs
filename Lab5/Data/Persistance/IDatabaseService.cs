using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Data.Persistance
{
    public interface IDatabaseService
    {
        DbSet<City> Cities { get; set; }
        int SaveChanges();
    }
}

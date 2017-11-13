using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Data.Domain.Entities;

namespace Data.Persistance.Context
{
    public class DataBaseContext : IDatabaseContext
    {
        public DbSet<Organisation> Organisations { set; get; }

        DataBaseContext(DbSet<Organisation> organisations)
        {
            this.Organisations = organisations;
        }

        public int SaveChanges()
        {
            throw new NotImplementedException();
        }
    
    }
}

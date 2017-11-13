using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using Data;
using Microsoft.EntityFrameworkCore;

namespace Business.Persistance
{
    class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {
            
        }

        private DbSet<City> Cities { get; set; }
    }
}

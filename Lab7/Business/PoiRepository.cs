using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data.Domain;
using Data.Persistance;
using Microsoft.EntityFrameworkCore;

namespace Business
{
    public class PoiRepository : IPoiRepository
    {
        public readonly IDatabaseContext _databaseContext;
        public DbSet<Poi> Pois { get; set; }

        public PoiRepository(IDatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public IReadOnlyList<Poi> GetAll() => _databaseContext.Pois.ToList();

        public Poi GetById(Guid id) => _databaseContext.Pois.FirstOrDefault(t => t.Id == id);

        public void Add(Poi poi)
        {
            _databaseContext.Pois.Add(poi);
            _databaseContext.SaveChanges();
        }

        public void Edit(Poi poi)
        {
            _databaseContext.Pois.Update(poi);
            _databaseContext.SaveChanges();
        }

        public void Delete(Guid id)
        {
            var poi = GetById(id);
            if (poi != null)
            {
                _databaseContext.Pois.Remove(poi);
                _databaseContext.SaveChanges();
            }
        }

    }
    
}

using System;
using System.Collections.Generic;
using Data.Domain;
using Microsoft.EntityFrameworkCore;

namespace Business
{
    public interface IPoiRepository
    {
        DbSet<Poi> Pois { get; set; }
        IReadOnlyList<Poi> GetAll();
        Poi GetById(Guid id);
        void Add(Poi poi);
        void Edit(Poi poi);
        void Delete(Guid id);
    }
}

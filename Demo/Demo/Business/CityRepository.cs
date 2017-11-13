using System;
using System.Collections.Generic;
using System.Linq;
using Data;
using Data.Persistence;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Business
{
    public class CityRepository : ICityRepository
    {
        private readonly IDatabaseService _service;

        public CityRepository(IDatabaseService service)
        {
            _service = service;
        }

        public void Add(City city)
        {
            _service.Cities.Add(city);
            _service.SaveChanges();
        }

        public IReadOnlyList<City> GetAll()
        {
            return _service.Cities.ToList();
        }
/*
        public void EditCity(City city, double rating)
        {
            city.
            city.Rating = rating;
        }

        public static void DeleteCity(City city)
        {
            city = null;
        }

        public City GetCityById(Guid id)
        {
            if (this.Id == id)
            {
                return this;
            }

            return null;
        }
        d.GetCityById
            e.GetAllCities
        f.GetCitiesBySpecifiedRating*/
    }
    
}

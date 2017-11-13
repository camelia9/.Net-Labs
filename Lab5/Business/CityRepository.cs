using System;
using System.Collections.Generic;
using System.Linq;
using Data;
using Data.Persistance;

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

            public void EditCity(City city, double rating) => city.Rating = rating;

        public void DeleteCity(City city)
            {
                _service.Cities.Remove(city);
            }

            public City GetCityById(Guid id)
            {
                List<City> cities = new List<City>();
                foreach (var city in _service.Cities)
                    cities.Add(city);
                return cities.Find(x => x.ID == id);
             }

            public IReadOnlyList<City> GetAll()
            {
                return _service.Cities.ToList();
            }

        public IReadOnlyList<City> GetCitiesBySpecifiedRating(double rating)
            {
            List<City> cities = _service.Cities.ToList();
                return cities.FindAll(x => x.Rating.CompareTo(rating) == rating);
        }
       
        }
}

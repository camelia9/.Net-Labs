using System;
using System.Collections.Generic;
using Data;

namespace Business
{
    public interface ICityRepository
    {
        void Add(City city);
        void EditCity(City city, double rating);
        void DeleteCity(City city);
        City GetCityById(Guid id);
        IReadOnlyList<City> GetAll();
        IReadOnlyList<City> GetCitiesBySpecifiedRating(double rating);
    }
}
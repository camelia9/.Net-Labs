using System;
using Data.Domain.Entities;
using Data.Persistance.Context;

namespace BunsinessClass
{
    public class OrganisationRepository
    {
        private readonly IDatabaseContext _service;
        public OrganisationRepository(IDatabaseContext service)
        {
            _service = service;
        }

        public void Add(OrganisationRepository organisation)
        {
            _service.Organisations.Add(organisation);
            _service.SaveChanges();
        }

        public void EditCity(Organisation city, double rating) => city.Rating = rating;

        public void DeleteCity(City city)
        {
            _service.Cities.Remove(city);
        }

    }
}

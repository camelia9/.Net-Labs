using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using Data.Domain.Entities;
using Data.Domain.Interfaces;
using Data.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Business
{
    public class OrganizationRepository : IOrganizationRepository
    {
        private readonly IDatabaseContext _databaseContext;

        public OrganizationRepository(IDatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public IReadOnlyList<Organization> GetAll() => _databaseContext.Organizations.ToList();

        public IReadOnlyList<Organization> GetAllEager()
        {
            var users = _databaseContext.Organizations.Find(1);
            var query = _databaseContext.Organizations.Include("Users");
            return query.ToImmutableList();

        }

        public int GetUsersNumberEager()
        {
            var users = _databaseContext.Organizations.Find(1);
            var query = _databaseContext.Organizations.Include("Users");
            return query.Count();
        }

        public Organization GetById(Guid id) => _databaseContext.Organizations.FirstOrDefault(t => t.Id == id);

        public void Add(Organization organization)
        {
            _databaseContext.Organizations.Add(organization);
            _databaseContext.SaveChanges();
        }

        public void Edit(Organization organization)
        {
            _databaseContext.Organizations.Update(organization);
            _databaseContext.SaveChanges();
        }

        public void Delete(Guid id)
        {
            var organization = GetById(id);
            if (organization != null)
            {
                _databaseContext.Organizations.Remove(organization);
                _databaseContext.SaveChanges();
            }
        }

  
    }
}

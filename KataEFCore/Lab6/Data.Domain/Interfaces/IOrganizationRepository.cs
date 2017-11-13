using System;
using System.Collections.Generic;
using System.Text;
using Data.Domain.Entities;

namespace Data.Domain.Interfaces
{
    public interface IOrganizationRepository
    {
        IReadOnlyList<Organization> GetAll();
        Organization GetById(Guid id);
        void Add(Organization organization);
        void Edit(Organization organization);
        void Delete(Guid id);

    }
}

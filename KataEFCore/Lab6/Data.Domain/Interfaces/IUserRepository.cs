using System;
using System.Collections.Generic;
using Data.Domain.Entities;

namespace Data.Domain.Interfaces
{
    public interface IUserRepository
    {
        IReadOnlyList<User> GetAll();
        User GetById(Guid id);
        void Add(User user);
        void Edit(User user);
        void Delete(Guid id);
    }
}

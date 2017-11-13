﻿using System;
using System.Collections.Generic;
using System.Linq;
using Data.Domain.Entities;
using Data.Domain.Interfaces;
using Data.Persistence;

namespace Business
{
    public class UserRepository : IUserRepository
    {
        private readonly IDatabaseContext _databaseContext;

        public UserRepository(IDatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public IReadOnlyList<User> GetAll() => _databaseContext.Users.ToList();

        public User GetById(Guid id) => _databaseContext.Users.FirstOrDefault(t => t.Id == id);

        public void Add(User user) {
            _databaseContext.Users.Add(user);
            _databaseContext.SaveChanges();
        }

        public void Edit(User user)
        {
            _databaseContext.Users.Update(user);
            _databaseContext.SaveChanges();
        }

        public void Delete(Guid id)
        {
            var user = GetById(id);
            if (user != null)
            {
                _databaseContext.Users.Remove(user);
                _databaseContext.SaveChanges();
            }
        }
    }
}

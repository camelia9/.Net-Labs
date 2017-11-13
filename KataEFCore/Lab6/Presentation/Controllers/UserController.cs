﻿using System;
using System.Collections.Generic;
using Data.Domain.Entities;
using Data.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Presentation.DTOs;

namespace Presentation.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly IUserRepository _repository;

        public UserController(IUserRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IEnumerable<User> Get()
        {
            return _repository.GetAll();
        }

        [HttpGet("{id:guid}")]
        public User Get(Guid id)
        {
            return _repository.GetById(id);
        }

        [HttpPost]
        public void Post([FromBody]CreateUserModel user)
        {
            var entity = Data.Domain.Entities.User.Create(user.FirstName, user.LastName, user.Email);
            _repository.Add(entity);
        }

        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody]UpdateUserModel user)
        {
            var entity = _repository.GetById(id);
            entity.Update(user.FirstName, user.LastName, user.Email);
            _repository.Edit(entity);
        }

        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _repository.Delete(id);
        }
    }
}

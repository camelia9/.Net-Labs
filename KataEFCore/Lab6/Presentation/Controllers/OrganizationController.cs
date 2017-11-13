using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data.Domain.Entities;
using Data.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Presentation.DTOs;

namespace Presentation.Controllers
{
    [Route("api/[controller]")]
    public class OrganizationController : Controller
    {
        private readonly IOrganizationRepository _repository;

        public OrganizationController(IOrganizationRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public IEnumerable<Organization> Get()
        {
            return _repository.GetAll();
        }
        [HttpGet("{id:guid}")]
        public Organization Get(Guid id)
        {
            return _repository.GetById(id);
        }
        [HttpPost]
        public void Post([FromBody]CreateOrganizationModel org)
        {
            var entity = Organization.Create(org.Name, org.Description, org.UserList);
            _repository.Add(entity);
        }

        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody]UpdateOrganziationModel org)
        {
            var entity = _repository.GetById(id);
            entity.Update(org.Name, org.Description, org.UserList);
            _repository.Edit(entity);
        }

        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _repository.Delete(id);
        }

        
    }
}

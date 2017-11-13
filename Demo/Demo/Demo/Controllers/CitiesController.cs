using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business;
using Data;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
    [Route("api/cities")]
    public class CitiesController : Controller
    {
        private readonly ICityRepository _repository;

        public CitiesController(ICityRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IEnumerable<City> Get()
        {
            return _repository.GetAll();
        }

        [HttpPost]
        public IActionResult Add([FromBody] City city)
        {
            if (city == null)
            {
                return BadRequest();
            }
            _repository.Add(city);
            return Ok(city);
        }

    }
}

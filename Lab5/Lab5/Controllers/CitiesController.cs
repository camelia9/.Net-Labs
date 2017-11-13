using System;
using System.Collections.Generic;
using Business;
using Data;
using Microsoft.AspNetCore.Mvc;

namespace Lab5.Controllers
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

        [HttpPost]
        public IActionResult EditCity(City city, double rating)
        {
            if (city == null)
            {
                return BadRequest();
            }
            _repository.EditCity(city, rating);
            return Ok(city);
        }

        [HttpDelete]
        public IActionResult DeleteCity(City city)
        {
            if (city == null)
                return BadRequest();
            _repository.DeleteCity(city);
            return Ok(city);
        }

        [HttpGet]
        public City GetCityById(Guid id)
        {
            return _repository.GetCityById(id);
        }

        [HttpGet]
        public IEnumerable<City> GetCitiesBySpecifiedRating(double rating)
        {
            return _repository.GetCitiesBySpecifiedRating(rating);
        }
        

    }
}
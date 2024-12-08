using Microsoft.AspNetCore.Mvc;
using Final_Project.Interfaces;
using Final_Project.Models;

namespace Final_Project.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CityController : ControllerBase
    {
         private readonly ILogger<CityController> _logger;
        private readonly IFinalProjectContextDAO _context;
        public CityController(ILogger<CityController> logger, IFinalProjectContextDAO context)
        {
            _logger = logger;
            _context = context;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_context.GetAllCities());
        }
        [HttpGet("id")]
        public IActionResult Get(int id)
        {
            var city = _context.GetCity(id);

            if (city == null) return NotFound(id);
            return Ok(_context.GetCity(id));
        }
        [HttpDelete("id")]
        public IActionResult Delete(int id)
        {
            var result = _context.RemoveCityByID(id);

            if (result == null) return NotFound(id);
            if (result == 0) return StatusCode(500, "An error occurred");
            return Ok();
        }
        [HttpPut]
        public IActionResult Put(City city)
        {   var result = _context.UpdateCity(city);

            if (result == null) return NotFound(city.Id);
            if (result == 0) return StatusCode(500, "An error occurred");
            return Ok();
        }
        [HttpPost]
        public IActionResult Post(City city)
        {
            var result = _context.Add(city);

            if (result == null) return StatusCode(500, "City already exists");
            if (result == 0) return StatusCode(500, "An error occurred");
            return Ok();
        }
    }
}
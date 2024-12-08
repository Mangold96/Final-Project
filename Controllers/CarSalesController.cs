using Microsoft.AspNetCore.Mvc;
using Final_Project.Interfaces;
using Final_Project.Models;

namespace Final_Project.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarSalesController : ControllerBase
    {
        private readonly ILogger<CarSalesController> _logger;
        private readonly IFinalProjectContextDAO _context;
        public CarSalesController(ILogger<CarSalesController> logger, IFinalProjectContextDAO context)
        {
            _logger = logger;
            _context = context;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_context.GetAllSales());
        }
        [HttpGet("id")]
        public IActionResult Get(int id)
        {
            var carSales = _context.GetSale(id);

            if (carSales == null) return NotFound(id);
            return Ok(_context.GetSale(id));
        }
        [HttpDelete("id")]
        public IActionResult Delete(int id)
        {
            var result = _context.RemoveSaleByID(id);

            if (result == null) return NotFound(id);
            if (result == 0) return StatusCode(500, "An error occurred");
            return Ok();
        }
        [HttpPut]
        public IActionResult Put(CarSales carSales)
        {   var result = _context.UpdateSale(carSales);

            if (result == null) return NotFound(carSales.Id);
            if (result == 0) return StatusCode(500, "An error occurred");
            return Ok();
        }
        [HttpPost]
        public IActionResult Post(CarSales carSales)
        {
            var result = _context.Add(carSales);

            if (result == null) return StatusCode(500, "Sale already exists");
            if (result == 0) return StatusCode(500, "An error occurred");
            return Ok();
        }
    }
}
using Final_Project.Interfaces;
using Final_Project.Models;
using Microsoft.AspNetCore.Mvc;



namespace Final_Project.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OlympicSportsController : ControllerBase
    {
        private readonly ILogger<OlympicSportsController> _logger;
        private readonly IFinalProjectContextDAO _context;
        public OlympicSportsController(ILogger<OlympicSportsController> logger, IFinalProjectContextDAO context)
        {
            _logger = logger;
            _context = context;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_context.GetAllSports());
        }
        [HttpGet("id")]
        public IActionResult Get(int id)
        {
            var olympicSport = _context.GetSport(id);

            if (olympicSport == null) return NotFound(id);
            return Ok(_context.GetSport(id));
        }
        [HttpDelete("id")]
        public IActionResult Delete(int id)
        {
            var result = _context.RemoveSportByID(id);

            if (result == null) return NotFound(id);
            if (result == 0) return StatusCode(500, "An error occurred");
            return Ok();
        }
        [HttpPut]
        public IActionResult Put(OlympicSports olympicSports)
        {   var result = _context.UpdateSport(olympicSports);

            if (result == null) return NotFound(olympicSports.Id);
            if (result == 0) return StatusCode(500, "An error occurred");
            return Ok();
        }
        [HttpPost]
        public IActionResult Post(OlympicSports olympicSports)
        {
            var result = _context.Add(olympicSports);

            if (result == null) return StatusCode(500, "Sport already exists");
            if (result == 0) return StatusCode(500, "An error occurred");
            return Ok();
        }
    }
}
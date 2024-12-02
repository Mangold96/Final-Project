using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Final_Project.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TeamMemberController : ControllerBase
    {
        private readonly ILogger<TeamMemberController> _logger;
        public TeamMemberController(ILogger<TeamMemberController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }
    }
}

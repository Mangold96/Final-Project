using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Final_Project.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TeamMembersController : Controller
    {
        private readonly ILogger<TeamMembersController> _logger;
        public TeamMembersController(ILogger<TeamMembersController> logger)
        {
            _logger = logger;
        }

        public IActionResult Get()
        {
            return Ok();
        }
    }
}

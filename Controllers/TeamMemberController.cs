using System;
using System.Collections.Generic;
using System.Linq;
using Final_Project.Data;
using Final_Project.Interfaces;
using Final_Project.Migrations;
using Final_Project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Final_Project.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TeamMemberController : ControllerBase
    {
        private readonly ILogger<TeamMemberController> _logger;
        private readonly IFinalProjectContextDAO _context;
        public TeamMemberController(ILogger<TeamMemberController> logger, IFinalProjectContextDAO context)
        {
            _logger = logger;
            _context = context;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_context.GetAllTeamMembers());
        }
        [HttpGet("id")]
        public IActionResult Get(int id)
        {
            var teamMember = _context.GetTeamMember(id);

            if (teamMember == null) return NotFound(id);
            return Ok(_context.GetTeamMember(id));
        }
        [HttpDelete("id")]
        public IActionResult Delete(int id)
        {
            var result = _context.RemoveTeamMemberByID(id);

            if (result == null) return NotFound(id);
            if (result == 0) return StatusCode(500, "An error occurred");
            return Ok();
        }
        [HttpPut]
        public IActionResult Put(TeamMember teamMember)
        {   var result = _context.UpdateTeamMember(teamMember);

            if (result == null) return NotFound(teamMember.Id);
            if (result == 0) return StatusCode(500, "An error occurred");
            return Ok();
        }
        [HttpPost]
        public IActionResult Post(TeamMember teamMember)
        {
            var result = _context.Add(teamMember);

            if (result == null) return StatusCode(500, "Team member already exists");
            if (result == 0) return StatusCode(500, "An error occurred");
            return Ok();
        }
    }
}

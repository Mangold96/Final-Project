using System;
using System.Collections.Generic;
using System.Linq;
using Final_Project.Data;
using Final_Project.Interfaces;
using Final_Project.Migrations;
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
        public IActionResult GetAllTeamMembers()
        {
            return Ok(_context.GetAllTeamMembers());
        }
        [HttpGet("id")]
        public IActionResult GetTeamMemberByID(int id)
        {
            var teamMember = _context.GetTeamMember(id);
            if (teamMember == null) return NotFound(id);
            return Ok(_context.GetTeamMember(id));
        }
        [HttpDelete]
        public IActionResult DeleteTeamMemberByID(int id)
        {
            var teamMember = _context.RemoveTeamMemberByID(id);
            if (teamMember == null) 
            {
                return NotFound(id);
            }
            if (string.IsNullOrEmpty(teamMember.StudentName))
            {
                return StatusCode(500, "An error occurred");
            }
            return Ok();
        }
        
    }
}

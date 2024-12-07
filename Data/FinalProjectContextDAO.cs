using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Final_Project.Interfaces;
using Final_Project.Models;

namespace Final_Project.Data
{
    public class FinalProjectContextDAO : IFinalProjectContextDAO
    {
        private FinalProjectDBContext _context;
        public FinalProjectContextDAO(FinalProjectDBContext context)
        {
            _context = context;
        }
         public List<TeamMember> GetAllTeamMembers()
        {
            return _context.FinalProjectTeam.ToList();
        }

        public TeamMember GetTeamMember(int id)
        {
            return _context.FinalProjectTeam.Where(x => x.Id.Equals(id)).FirstOrDefault();
        }
        public TeamMember RemoveTeamMemberByID(int id)
        {
            var teamMember = this.GetTeamMember(id);
            if (teamMember == null) return null;
            try
            {
            _context.FinalProjectTeam.Remove(teamMember);
            _context.SaveChanges();
            return teamMember;
            }
            catch(Exception)
            {
                return new TeamMember();
            }
        }
    }  
}
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
        public int? RemoveTeamMemberByID(int id)
        {
            var teamMember = this.GetTeamMember(id);
            if (teamMember == null) return null;
            try
            {
            _context.FinalProjectTeam.Remove(teamMember);
            _context.SaveChanges();
            return 1;
            }
            catch(Exception)
            {
                return 0;
            }
        }

        public int? UpdateTeamMember(TeamMember teamMember)
        {
            var teamMemberToUpdate = this.GetTeamMember(teamMember.Id);
            if (teamMemberToUpdate == null) return null;
            teamMemberToUpdate.StudentName = teamMember.StudentName;
            teamMemberToUpdate.StudentBirthdate = teamMember.StudentBirthdate;
            teamMemberToUpdate.CollegeProgram = teamMember.CollegeProgram;
            teamMemberToUpdate.ProgramYear = teamMember.ProgramYear;
            try
            {
            _context.FinalProjectTeam.Update(teamMemberToUpdate);
            _context.SaveChanges();
            return 1;
            }
            catch(Exception)
            {
                return 0;
            }
        }
        public int? Add(TeamMember teamMember)
        {
            var teamMemberToAdd = _context.FinalProjectTeam.Where(x => x.StudentName.Equals(teamMember.StudentName) 
                && x.CollegeProgram.Equals(teamMember.CollegeProgram)).FirstOrDefault();

            if (teamMemberToAdd != null) return null;
            try
            {
                _context.FinalProjectTeam.Add(teamMember);
                _context.SaveChanges();
                return 1;
            }
            catch(Exception)
            {
                return 0;
            }
            
        }

    }  
}
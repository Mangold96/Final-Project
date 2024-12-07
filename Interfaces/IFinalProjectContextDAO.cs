using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Final_Project.Models;

namespace Final_Project.Interfaces
{
    public interface IFinalProjectContextDAO
    {
        List<TeamMember> GetAllTeamMembers();
        TeamMember GetTeamMember(int id);
        int? RemoveTeamMemberByID(int id);
        int? UpdateTeamMember(TeamMember teamMember);
        int? Add(TeamMember teamMember);
    }
}
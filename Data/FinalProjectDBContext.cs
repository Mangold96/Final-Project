using Final_Project.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using Microsoft.VisualBasic;
namespace Final_Project.Data
{
    public class FinalProjectDBContext : DbContext
    {
        public FinalProjectDBContext(DbContextOptions dbContextOptionsoptions) : base(dbContextOptionsoptions) {}

        public DbSet<TeamMember> FinalProjectTeam { get; set; }
    }
}

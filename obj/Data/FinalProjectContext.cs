using Microsoft.EntityFrameworkCore;
namespace Final_Project.Data
{
    public class FinalProjectContext : DbContext
    {
        public FinalProjectContext(DbContextOptions<FinalProjectContext> options) : base(options) {}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<TeamMember>().HasData(
                new TeamMember {Id = 1, StudentName = "Kevin Mangold", StudentBirthdate = (1996, 2, 4, 0, 0, 0),
                CollegeProgram = "IT", ProgramYear = "Junior" }
                );
        }

        public DbSet<TeamMember> FinalProjectTeam { get; set; }
    }
}

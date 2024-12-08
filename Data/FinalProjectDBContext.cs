using Final_Project.Models;
using Microsoft.EntityFrameworkCore;
namespace Final_Project.Data
{
    public class FinalProjectDBContext : DbContext
    {
        public FinalProjectDBContext(DbContextOptions dbContextOptionsoptions) : base(dbContextOptionsoptions) {}
        public DbSet<TeamMember> FinalProjectTeam { get; set; }
        public DbSet<OlympicSports> OlympicSportsTable { get; set; }
        public DbSet<CarSales> CarSalesTable { get; set; }
        public DbSet<City> CitiesTable { get; set; }
    }
}

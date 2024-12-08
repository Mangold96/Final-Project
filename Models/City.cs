
namespace Final_Project.Models
{
    public class City
    {
        public int Id { get; set; }
        public string CityName { get; set; } = string.Empty;
        public DateOnly? DateFounded { get; set; }
        public int Population { get; set; }
        public int ProfessionalSportsTeams { get; set; }
    }
}
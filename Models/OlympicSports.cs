
namespace Final_Project.Models
{
    public class OlympicSports
    {
        public int Id { get; set; }
        public string SportName { get; set; } = string.Empty;
        public DateOnly? DateAdded { get; set; }
        public int ParticipatingCountries { get; set; }
        public string SportSeason { get; set; } = string.Empty;
    }
}
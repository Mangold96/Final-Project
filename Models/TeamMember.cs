namespace Final_Project.Models
{
    public class TeamMember
    {
        public int Id { get; set; }
        public string StudentName { get; set; } = string.Empty;
        public DateTime? StudentBirthdate { get; set; }
        public string CollegeProgram { get; set; } = string.Empty;
        public string ProgramYear { get; set; } = string.Empty;
    }
}
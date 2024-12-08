
namespace Final_Project.Models
{
    public class CarSales
    {
        
        public int Id { get; set; }
        public string Manufacturer { get; set; } = string.Empty;
        public DateOnly? DateFounded { get; set; }
        public int TotalSales { get; set; }
        public int YearlyAverage { get; set; }
    }
}
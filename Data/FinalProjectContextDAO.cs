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
        // Team Member Specific
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
        
        // Olympic Sport Specific
        public List<OlympicSports> GetAllSports()
        {
            return _context.OlympicSportsTable.ToList();
        }
        public OlympicSports GetSport(int id)
        {
            return _context.OlympicSportsTable.Where(x => x.Id.Equals(id)).FirstOrDefault();
        }
        public int? RemoveSportByID(int id)
        {
            var olympicSports = this.GetSport(id);
            if (olympicSports == null) return null;
            try
            {
            _context.OlympicSportsTable.Remove(olympicSports);
            _context.SaveChanges();
            return 1;
            }
            catch(Exception)
            {
                return 0;
            }
        }
        public int? UpdateSport(OlympicSports olympicSports)
        {
            var sportToUpdate = this.GetSport(olympicSports.Id);
            if (sportToUpdate == null) return null;
            sportToUpdate.SportName = olympicSports.SportName;
            sportToUpdate.DateAdded = olympicSports.DateAdded;
            sportToUpdate.ParticipatingCountries = olympicSports.ParticipatingCountries;
            sportToUpdate.SportSeason = olympicSports.SportSeason;
            try
            {
            _context.OlympicSportsTable.Update(sportToUpdate);
            _context.SaveChanges();
            return 1;
            }
            catch(Exception)
            {
                return 0;
            }
        }
        public int? Add(OlympicSports olympicSports)
        {
            var sportToAdd = _context.OlympicSportsTable.Where(x => x.SportName.Equals(olympicSports.SportName) 
                && x.SportSeason.Equals(olympicSports.SportSeason)).FirstOrDefault();

            if (sportToAdd != null) return null;
            try
            {
                _context.OlympicSportsTable.Add(olympicSports);
                _context.SaveChanges();
                return 1;
            }
            catch(Exception)
            {
                return 0;
            }
        }
        
        // Car Sales Specific
        public List<CarSales> GetAllSales()
        {
            return _context.CarSalesTable.ToList();
        }
        public CarSales GetSale(int id)
        {
            return _context.CarSalesTable.Where(x => x.Id.Equals(id)).FirstOrDefault();
        }
        public int? RemoveSaleByID(int id)
        {
            var carSales = this.GetSale(id);
            if (carSales == null) return null;
            try
            {
            _context.CarSalesTable.Remove(carSales);
            _context.SaveChanges();
            return 1;
            }
            catch(Exception)
            {
                return 0;
            }
        }
        public int? UpdateSale(CarSales carSales)
        {
            var saleToUpdate = this.GetSale(carSales.Id);
            if (saleToUpdate == null) return null;
            saleToUpdate.Manufacturer = carSales.Manufacturer;
            saleToUpdate.DateFounded = carSales.DateFounded;
            saleToUpdate.TotalSales = carSales.TotalSales;
            saleToUpdate.YearlyAverage = carSales.YearlyAverage;
            try
            {
            _context.CarSalesTable.Update(saleToUpdate);
            _context.SaveChanges();
            return 1;
            }
            catch(Exception)
            {
                return 0;
            }
        }
        public int? Add(CarSales carSales)
        {
            var saleToAdd = _context.CarSalesTable.Where(x => x.Manufacturer.Equals(carSales.Manufacturer) 
                && x.DateFounded.Equals(carSales.DateFounded)).FirstOrDefault();

            if (saleToAdd != null) return null;
            try
            {
                _context.CarSalesTable.Add(carSales);
                _context.SaveChanges();
                return 1;
            }
            catch(Exception)
            {
                return 0;
            }
        }

        // City Specific
        public List<City> GetAllCities()
        {
            return _context.CitiesTable.ToList();
        }
        public City GetCity(int id)
        {
            return _context.CitiesTable.Where(x => x.Id.Equals(id)).FirstOrDefault();
        }
        public int? RemoveCityByID(int id)
        {
            var city = this.GetCity(id);
            if (city == null) return null;
            try
            {
            _context.CitiesTable.Remove(city);
            _context.SaveChanges();
            return 1;
            }
            catch(Exception)
            {
                return 0;
            }
        }
        public int? UpdateCity(City city)
        {
            var cityToUpdate = this.GetCity(city.Id);
            if (cityToUpdate == null) return null;
            cityToUpdate.CityName = city.CityName;
            cityToUpdate.DateFounded = city.DateFounded;
            cityToUpdate.Population = city.Population;
            cityToUpdate.ProfessionalSportsTeams = city.ProfessionalSportsTeams;
            try
            {
            _context.CitiesTable.Update(cityToUpdate);
            _context.SaveChanges();
            return 1;
            }
            catch(Exception)
            {
                return 0;
            }
        }
        public int? Add(City city)
        {
            var cityToAdd = _context.CitiesTable.Where(x => x.CityName.Equals(city.CityName) 
                && x.DateFounded.Equals(city.DateFounded)).FirstOrDefault();

            if (cityToAdd != null) return null;
            try
            {
                _context.CitiesTable.Add(city);
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
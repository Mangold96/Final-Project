using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Final_Project.Models;

namespace Final_Project.Interfaces
{
    public interface IFinalProjectContextDAO
    {
        // Team Member specific
        List<TeamMember> GetAllTeamMembers();
        TeamMember GetTeamMember(int id);
        int? RemoveTeamMemberByID(int id);
        int? UpdateTeamMember(TeamMember teamMember);
        int? Add(TeamMember teamMember);

        // Olympic Sport Specific
        List<OlympicSports> GetAllSports();
        OlympicSports GetSport(int id);
        int? RemoveSportByID(int id);
        int? UpdateSport(OlympicSports olympicSports);
        int? Add(OlympicSports olympicSports);

        // Car Sales Specific
        List<CarSales> GetAllSales();
        CarSales GetSale(int id);
        int? RemoveSaleByID(int id);
        int? UpdateSale(CarSales carSales);
        int? Add(CarSales carSales);

        // City Specific
        List<City> GetAllCities();
        City GetCity(int id);
        int? RemoveCityByID(int id);
        int? UpdateCity(City city);
        int? Add(City city);
    }
}
using System.Collections.Generic;
using AFTNService.Models;

namespace AFTNService.Data
{
    public interface IFlightInformationRepo
    {
        bool SaveChanges();

        IEnumerable<FlightInformation> GetAllFlightInfo();
        FlightInformation GetFlightInfoById(int id);
        void CreateFlightInformation(FlightInformation flightInfo);
    }
}
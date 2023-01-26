using AircraftApronService.Models;

namespace AircraftApronService.Data
{
    public interface IAircraftApronHandlingRepo
    {
        bool SaveChanges();
        IEnumerable<AircraftApronHandling> GetAllApronHandling();
        AircraftApronHandling GetApronHandlingById(int id);
        void CreateApronHandling(AircraftApronHandling aircraftApronHandling);
    }
}
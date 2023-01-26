using AircraftApronService.Models;

namespace AircraftApronService.Data
{
    public interface IPassengerBNGRepo
    {
        bool SaveChanges();
        IEnumerable<PassengerBoardingAndGuidance> GetallPassengerBNG();
        PassengerBoardingAndGuidance GetPassengerBNGById(int id);
        void CreatePassengerBNG(PassengerBoardingAndGuidance passengerBoardingAndGuidance);
    }
}
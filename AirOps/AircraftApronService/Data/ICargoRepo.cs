using AircraftApronService.Models;

namespace AircraftApronService.Data
{
    public interface ICargoRepo
    {
        bool SaveChanges();

        IEnumerable<Cargo> GetAllCargo();
        Cargo GetCargoById(int id);
        void CreateCargo(Cargo cargo);
    }
}
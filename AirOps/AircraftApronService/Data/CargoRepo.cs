using AircraftApronService.Models;

namespace AircraftApronService.Data
{
    public class CargoRepo : ICargoRepo
    {
        private readonly AppDbContext _context;

        public CargoRepo(AppDbContext context)
        {
            _context = context;
        }

        public void CreateCargo(Cargo cargo)
        {
            if(cargo == null)
            {
                throw new ArgumentNullException(nameof(cargo));
            }
            _context.Cargos.Add(cargo);
        }

        public IEnumerable<Cargo> GetAllCargo()
        {
            return _context.Cargos.ToList();
        }

        public Cargo GetCargoById(int id)
        {
            return _context.Cargos.FirstOrDefault(c => c.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
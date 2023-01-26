using System.Collections.Generic;
using System.Linq;
using AircraftApronService.Models;

namespace AircraftApronService.Data
{
    public class AircraftApronHandlingRepo : IAircraftApronHandlingRepo
    {
        private readonly AppDbContext _context;

        public AircraftApronHandlingRepo(AppDbContext context)
        {
            _context = context;
        }

        public void CreateApronHandling(AircraftApronHandling aircraftApronHandling)
        {
            if(aircraftApronHandling == null)
            {
                throw new ArgumentNullException(nameof(aircraftApronHandling));
            }
            _context.APHandling.Add(aircraftApronHandling);
        }

        public IEnumerable<AircraftApronHandling> GetAllApronHandling()
        {
            return _context.APHandling.ToList();
        }

        public AircraftApronHandling GetApronHandlingById(int id)
        {
           return _context.APHandling.FirstOrDefault(aph => aph.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
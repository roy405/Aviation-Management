using System.Collections.Generic;
using System.Linq;
using AFTNService.Models;

namespace AFTNService.Data
{
    public class FlightInformationRepo : IFlightInformationRepo
    {
        private readonly AppDbContext _context;

        public FlightInformationRepo(AppDbContext context)
        {
            _context = context;
        }

        public void CreateFlightInformation(FlightInformation flightInfo)
        {
            if(flightInfo == null)
            {
                throw new ArgumentNullException(nameof(flightInfo));
            }
            
            _context.FlightInfo.Add(flightInfo);
        }

        public IEnumerable<FlightInformation> GetAllFlightInfo()
        {
            return _context.FlightInfo.ToList();
        }

        public FlightInformation GetFlightInfoById(int id)
        {
            return _context.FlightInfo.FirstOrDefault(fi => fi.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
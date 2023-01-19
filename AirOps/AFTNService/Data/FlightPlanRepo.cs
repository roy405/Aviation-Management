using System.Collections.Generic;
using System.Linq;
using AFTNService.Models;

namespace AFTNService.Data
{
    public class FlightPlanRepo : IFlightPlanRepo
    {
        private readonly AppDbContext _context;

        public FlightPlanRepo(AppDbContext context)
        {
            _context = context;
        }

        public void CreateFlightPlan(FlightPlan flightPlan)
        {
            if (flightPlan == null)
            {
                throw new ArgumentNullException(nameof(flightPlan));
            }
            _context.FlightPlan.Add(flightPlan);
        }

        public IEnumerable<FlightPlan> GetAllFlightPlans()
        {
            return _context.FlightPlan.ToList();
        }

        public FlightPlan GetFlightPlanById(int id)
        {
            return _context.FlightPlan.FirstOrDefault( fp => fp.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
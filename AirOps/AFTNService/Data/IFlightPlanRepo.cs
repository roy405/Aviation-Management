using System.Collections.Generic;
using AFTNService.Models;

namespace AFTNService.Data
{
    public interface IFlightPlanRepo
    {
        bool SaveChanges();

        IEnumerable<FlightPlan> GetAllFlightPlans();
        FlightPlan GetFlightPlanById(int id);
        void CreateFlightPlan(FlightPlan flightPlan);
    }
}
using AutoMapper;
using AFTNService.Dtos;
using AFTNService.Models;

namespace AFTNService.Profiles
{
    public class FlightPlanProfile : Profile
    {
        public FlightPlanProfile()
        {
            CreateMap<FlightPlan, ReadFlightPlanDto>();
            CreateMap<CreateFlightPlanDto, FlightPlan>();
        }
    }
}
using AutoMapper;
using AFTNService.Dtos;
using AFTNService.Models;

namespace AFTNService.Profiles
{
    public class FlightInformationProfile : Profile
    {
        public FlightInformationProfile()
        {
            CreateMap<FlightInformation, ReadFlightInfoDto>();
            CreateMap<CreateFlightInfoDto, FlightInformation>();
        }
    }
}
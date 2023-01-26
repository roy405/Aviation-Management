using AutoMapper;
using AircraftApronService.Dtos;
using AircraftApronService.Models;

namespace AircraftApronService.Profiles
{
    public class PassengerBNGProfile : Profile
    {
        public PassengerBNGProfile()
        {
            //         Source --> Target
            CreateMap<PassengerBoardingAndGuidance, ReadPBGDto>();
            CreateMap<CreatePBGDto, PassengerBoardingAndGuidance>();
        }
    }
}
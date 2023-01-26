using AutoMapper;
using AircraftApronService.Dtos;
using AircraftApronService.Models;

namespace AircraftApronService.Profiles
{
    public class AircraftApronHandlingProfile : Profile
    {
        public AircraftApronHandlingProfile()
        {
            //         Source --> Target
            CreateMap<AircraftApronHandling, ReadAAHDto>();
            CreateMap<CreateAAHDto, AircraftApronHandling>();
        }
    }
}
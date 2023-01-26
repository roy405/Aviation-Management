using AutoMapper;
using AircraftApronService.Dtos;
using AircraftApronService.Models;

namespace AircraftApronService.Profiles
{
    public class CargoProfile : Profile
    {
        public CargoProfile()
        {
            //         Source --> Target
            CreateMap<Cargo, ReadCargoDto>();
            CreateMap<CreateCargoDto, Cargo>();
        }
    }
}
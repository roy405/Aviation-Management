using AutoMapper;
using ATCService.Data;
using ATCService.Dtos;
using ATCService.Models;

namespace ATCService.Profiles
{
    public class CommsProfile : Profile
    {
        public CommsProfile()
        {
            //         Source --> Target
            CreateMap<Comms, ReadCommsDto>();
            CreateMap<CreateCommsDto, Comms>();
        }
    }
}
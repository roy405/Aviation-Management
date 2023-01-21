using AutoMapper;
using ATCService.Data;
using ATCService.Dtos;
using ATCService.Models;

namespace ATCService.Profiles
{
    public class TarmacSecurityProfile : Profile
    {
        public TarmacSecurityProfile()
        {
            //         Source --> Target
            CreateMap<TarmacSecurityExec, ReadTarmacSecurityDto>();
            CreateMap<CreateTarmacSecurityDto, TarmacSecurityExec>();
        }
    }
}
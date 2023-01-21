using AutoMapper;
using ATCService.Data;
using ATCService.Dtos;
using ATCService.Models;

namespace ATCService.Profiles
{
    public class TarmacSafetyProfile : Profile
    {
        public TarmacSafetyProfile()
        {
            //         Source --> Target
            CreateMap<TarmacSafetyExec, ReadTarmacSafetyDto>();
            CreateMap<CreateTarmacSafetyDto, TarmacSafetyExec>();
        }
    }
}
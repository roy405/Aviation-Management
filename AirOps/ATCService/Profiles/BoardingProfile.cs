using AutoMapper;
using ATCService.Data;
using ATCService.Dtos;
using ATCService.Models;

namespace ATCService.Profiles
{
    public class BoardingProfile : Profile
    {
        public BoardingProfile()
        {
            //         Source --> Target
            CreateMap<Boarding, ReadBoardingDto>();
            CreateMap<CreateBoardingDto, Boarding>();
        }
    }
}
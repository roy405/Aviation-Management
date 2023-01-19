using AutoMapper;
using AFTNService.Dtos;
using AFTNService.Models;

namespace AFTNService.Profiles
{
    public class RunwayInformationProfile : Profile
    {
        public RunwayInformationProfile()
        {
            CreateMap<RunwayInformation, ReadRunwayInfoDto>();
            CreateMap<CreateRunwayInfoDto, RunwayInformation>();
        }
    }
}
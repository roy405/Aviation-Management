using AutoMapper;
using AFTNService.Dtos;
using AFTNService.Models;

namespace AFTNService.Profiles
{
    public class NavigationDataProfile : Profile
    {
        public NavigationDataProfile()
        {
            CreateMap<NavigationData, ReadNavDataDto>();
            CreateMap<CreateNavDataDto, NavigationData>();
        }
    }
}
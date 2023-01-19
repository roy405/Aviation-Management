using AutoMapper;
using AFTNService.Dtos;
using AFTNService.Models;

namespace AFTNService.Profiles
{
    public class StatusReportProfile : Profile
    {
        public StatusReportProfile()
        {
            CreateMap<StatusReport, ReadStatusReportDto>();
            CreateMap<CreateStatusReportDto, StatusReport>();
        }
    }
}
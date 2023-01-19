using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using AFTNService.Data;
using AFTNService.Dtos;
using AFTNService.Models;

namespace AFTNService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatusReportController : ControllerBase
    {
        private readonly IStatusReportRepo _repository;
        private readonly IMapper _mapper;

        public StatusReportController(IStatusReportRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ReadStatusReportDto>> GetStatusReport()
        {
            Console.WriteLine(" --> Getting all Status Reports.. ");
            var statusReportItems = _repository.GetAllStatusReport();
            return Ok(_mapper.Map<IEnumerable<ReadStatusReportDto>>(statusReportItems));
        }

        [HttpGet("{id}", Name = "GetStatusReportById")]
        public ActionResult<ReadStatusReportDto> GetStatusReportById(int id)
        {
            var statusReportItem = _repository.GetStatusReportbyId(id);
            if(statusReportItem != null)
            {
                return Ok(_mapper.Map<ReadStatusReportDto>(statusReportItem));
            }
            return NotFound();
        }

        [HttpPost]
        public ActionResult<ReadStatusReportDto> CreateStatusReport(CreateStatusReportDto createStatusReportDto)
        {
            var statusReportModel = _mapper.Map<StatusReport>(createStatusReportDto);
            _repository.CreateStatusReport(statusReportModel);
            _repository.SaveChanges();

            var statusReportDto = _mapper.Map<ReadStatusReportDto>(statusReportModel);

            return CreatedAtRoute(nameof(GetStatusReportById), new {Id = statusReportDto.Id}, statusReportDto);
        }
    }
}
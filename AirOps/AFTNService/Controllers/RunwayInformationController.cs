using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using AFTNService.Data;
using AFTNService.Dtos;
using AFTNService.Models;

namespace AFTNService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class RunwayInformationController : ControllerBase
    {
        private readonly IRunwayInformationRepo _repository;
        
        private readonly IMapper _mapper;

        public RunwayInformationController(IRunwayInformationRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ReadRunwayInfoDto>> GetRunwayInfo()
        {
            Console.WriteLine(" --> Getting all Runway Information... ");
            var runwayInfoItems = _repository.GetAllRunwayInfo();
            return Ok(_mapper.Map<IEnumerable<ReadRunwayInfoDto>>(runwayInfoItems));
        }

        [HttpGet("{id}", Name = "GetRunwayInfoById")]
        public ActionResult<ReadRunwayInfoDto> GetRunwayInfoById(int id)
        {
            var runwayInfoItem = _repository.GetRunwayInfoById(id);
            if(runwayInfoItem != null)
            {
                return Ok(_mapper.Map<ReadRunwayInfoDto>(runwayInfoItem));
            }
            return NotFound();
        }

        [HttpPost]
        public ActionResult<ReadRunwayInfoDto> CreateRunwayInfo(CreateRunwayInfoDto createRunwayInfoDto)
        {
            var runwayInfoModel= _mapper.Map<RunwayInformation>(createRunwayInfoDto);
            _repository.CreateRunwayInformation(runwayInfoModel);
            _repository.SaveChanges();

            var runwayInfoReadDto = _mapper.Map<ReadRunwayInfoDto>(runwayInfoModel);

            return CreatedAtRoute(nameof(GetRunwayInfoById), new {Id = runwayInfoReadDto.Id}, runwayInfoReadDto);
        }
    }
}
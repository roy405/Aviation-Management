using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using AFTNService.Data;
using AFTNService.Dtos;
using AFTNService.Models;

namespace AFTNService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightInformationController : ControllerBase
    {
        private readonly IFlightInformationRepo _repository;

        private readonly IMapper _mapper;

        public FlightInformationController(IFlightInformationRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ReadFlightInfoDto>> GetFlightInfo()
        {
            Console.WriteLine(" --> Getting all Flight Information... ");
            var flightInfoItems = _repository.GetAllFlightInfo();
            return Ok(_mapper.Map<IEnumerable<ReadFlightInfoDto>>(flightInfoItems));
        }

        [HttpGet("{id}", Name = "GetFlightInfoById")]
        public ActionResult<ReadFlightInfoDto> GetFlightInfoById(int id)
        {
            var flightInfoItem = _repository.GetFlightInfoById(id);
            if(flightInfoItem != null)
            {
                return Ok(_mapper.Map<ReadFlightInfoDto>(flightInfoItem));
            }
            return NotFound();
        }

        [HttpPost]
        public ActionResult<ReadFlightInfoDto> CreateFlightInfo(CreateFlightInfoDto createFlightInfoDto)
        {
            var flightInfoModel= _mapper.Map<FlightInformation>(createFlightInfoDto);
            _repository.CreateFlightInformation(flightInfoModel);
            _repository.SaveChanges();

            var flightInfoReadDto = _mapper.Map<ReadFlightInfoDto>(flightInfoModel);

            return CreatedAtRoute(nameof(GetFlightInfoById), new {Id = flightInfoReadDto.Id}, flightInfoReadDto);
        }
    }
}
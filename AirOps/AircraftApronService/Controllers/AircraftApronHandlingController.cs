using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using AircraftApronService.Data;
using AircraftApronService.Dtos;
using AircraftApronService.Models;

namespace AircraftApronService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AircraftApronHandlingController : ControllerBase
    {
        private readonly IAircraftApronHandlingRepo _repository;

        private readonly IMapper _mapper;

        public AircraftApronHandlingController(IAircraftApronHandlingRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ReadAAHDto>> GetAllAircraftAH()
        {
            Console.WriteLine(" --> Getting all AAHData...");

            var aahItems = _repository.GetAllApronHandling();
            return Ok(_mapper.Map<IEnumerable<ReadAAHDto>>(aahItems));
        }

        [HttpGet("{id}", Name = "GetAircraftAHById")]
        public ActionResult<ReadAAHDto> GetAircraftAHById(int id)
        {
            var aahItem = _repository.GetApronHandlingById(id);
            if(aahItem != null)
            {
                return Ok(_mapper.Map<ReadAAHDto>(aahItem));
            }

            return NotFound();
        }

        [HttpPost]
        public ActionResult<ReadAAHDto> CreateAircraftAH(CreateAAHDto createAAHDto)
        {
            var aircraftAHModel= _mapper.Map<AircraftApronHandling>(createAAHDto);
            _repository.CreateApronHandling(aircraftAHModel);
            _repository.SaveChanges();

            var aircraftAHReadDto = _mapper.Map<ReadAAHDto>(aircraftAHModel);

            return CreatedAtRoute(nameof(GetAircraftAHById), new {Id = aircraftAHReadDto.Id}, aircraftAHReadDto);
        }
    }
}   
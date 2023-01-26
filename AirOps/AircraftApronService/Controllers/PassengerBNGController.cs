using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using AircraftApronService.Data;
using AircraftApronService.Dtos;
using AircraftApronService.Models;

namespace AircraftApronService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PassengerBNGController : ControllerBase
    {
        private readonly IPassengerBNGRepo _repository;

        private readonly IMapper _mapper;

        public PassengerBNGController(IPassengerBNGRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<PassengerBoardingAndGuidance>> GetAllPBNG()
        {
            Console.WriteLine(" --> Getting all PBNG Data...");

            var pbngItems = _repository.GetallPassengerBNG();
            return Ok(_mapper.Map<IEnumerable<ReadPBGDto>>(pbngItems));
        }

        [HttpGet("{id}", Name = "GetPBNGById")]
        public ActionResult<ReadPBGDto> GetPBNGById(int id)
        {
            var pbngItem = _repository.GetPassengerBNGById(id);
            if(pbngItem != null)
            {
                return Ok(_mapper.Map<ReadPBGDto>(pbngItem));
            }

            return NotFound();
        }

        [HttpPost]
        public ActionResult<ReadPBGDto> CreatePBNG(CreatePBGDto createPBGDto)
        {
            var pbngModel= _mapper.Map<PassengerBoardingAndGuidance>(createPBGDto);
            _repository.CreatePassengerBNG(pbngModel);
            _repository.SaveChanges();

            var pbngReadDto = _mapper.Map<ReadPBGDto>(pbngModel);

            return CreatedAtRoute(nameof(GetPBNGById), new {Id = pbngReadDto.Id}, pbngReadDto);
        }
    }
}   
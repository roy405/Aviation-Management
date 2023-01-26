using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using AircraftApronService.Data;
using AircraftApronService.Dtos;
using AircraftApronService.Models;

namespace AircraftApronService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CargoController : ControllerBase
    {
        private readonly ICargoRepo _repository;

        private readonly IMapper _mapper;

        public CargoController(ICargoRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ReadCargoDto>> GetAllCargo()
        {
            Console.WriteLine(" --> Getting all Cargo Data...");

            var cargoItems = _repository.GetAllCargo();
            return Ok(_mapper.Map<IEnumerable<ReadCargoDto>>(cargoItems));
        }

        [HttpGet("{id}", Name = "GeCargoById")]
        public ActionResult<ReadCargoDto> GeCargoById(int id)
        {
            var cargoItem = _repository.GetCargoById(id);
            if(cargoItem != null)
            {
                return Ok(_mapper.Map<ReadCargoDto>(cargoItem));
            }

            return NotFound();
        }

        [HttpPost]
        public ActionResult<ReadCargoDto> CreateCargo(CreateCargoDto createCargoDto)
        {
            var cargoModel = _mapper.Map<Cargo>(createCargoDto);
            _repository.CreateCargo(cargoModel);
            _repository.SaveChanges();

            var cargoReadDto = _mapper.Map<ReadCargoDto>(cargoModel);

            return CreatedAtRoute(nameof(GeCargoById), new {Id = cargoReadDto.Id}, cargoReadDto);
        }
    }
}   
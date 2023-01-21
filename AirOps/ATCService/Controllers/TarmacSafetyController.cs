using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ATCService.Data;
using ATCService.Dtos;
using ATCService.Models;

namespace ATCService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TarmacSafetyController : ControllerBase
    {
        private readonly ITarmacSafetyRepo _repository;
        private readonly IMapper _mapper;

        public TarmacSafetyController(ITarmacSafetyRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ReadTarmacSafetyDto>> GetAllTarmacSafetyExec()
        {
            Console.WriteLine(" --> Getting Tarmac Safety Exec Data... ");
            var tarmacSafetyItems = _repository.GetAllTarmacSafetyExecs();
            return Ok(_mapper.Map<IEnumerable<ReadTarmacSafetyDto>>(tarmacSafetyItems));
        }

        [HttpGet("{id}", Name = "GetTarmacSafetyExecById")]
        public ActionResult<ReadTarmacSafetyDto> GetTarmacSafetyExecById(int id)
        {
            var tarmacSafetyItem = _repository.GetTarmacSafetyExecById(id);
            if(tarmacSafetyItem != null)
            {
                return Ok(_mapper.Map<ReadTarmacSafetyDto>(tarmacSafetyItem));
            }

            return NotFound();
        }

        [HttpPost]
        public ActionResult<ReadTarmacSafetyDto> CreateTarmacSafetyExec(CreateTarmacSafetyDto createTarmacSafetyDto)
        {
            var tarmacSafetyModel = _mapper.Map<TarmacSafetyExec>(createTarmacSafetyDto);
            _repository.CreateTarmacSafetyExec(tarmacSafetyModel);
            _repository.SaveChanges();

            var readTarmacSafetyDto = _mapper.Map<ReadTarmacSafetyDto>(tarmacSafetyModel);

            return CreatedAtRoute(nameof(GetTarmacSafetyExecById), new {Id = readTarmacSafetyDto.Id}, readTarmacSafetyDto);
        }
    }
}
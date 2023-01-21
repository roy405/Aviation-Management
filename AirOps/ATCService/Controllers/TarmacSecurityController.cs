using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ATCService.Data;
using ATCService.Dtos;
using ATCService.Models;

namespace ATCService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TarmacSecurityController : ControllerBase
    {
        private readonly ITarmacSecurityRepo _repository;
        private readonly IMapper _mapper;

        public TarmacSecurityController(ITarmacSecurityRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ReadTarmacSecurityDto>> GetAllTarmacSecurityExec()
        {
            Console.WriteLine(" --> Getting Tarmac Security Exec Data... ");
            var tarmacSecurityItems = _repository.GetAllTarmacSecurityExecs();
            return Ok(_mapper.Map<IEnumerable<ReadTarmacSecurityDto>>(tarmacSecurityItems));
        }

        [HttpGet("{id}", Name = "GetTarmacSecurityExecById")]
        public ActionResult<ReadTarmacSafetyDto> GetTarmacSafetyExecById(int id)
        {
            var tarmacSecurityItem = _repository.GetTarmacSecurityExecById(id);
            if(tarmacSecurityItem != null)
            {
                return Ok(_mapper.Map<ReadTarmacSecurityDto>(tarmacSecurityItem));
            }

            return NotFound();
        }

        [HttpPost]
        public ActionResult<ReadTarmacSecurityDto> CreateTarmacSecurityExec(CreateTarmacSecurityDto createTarmacSecurityDto)
        {
            var tarmacSecurityModel = _mapper.Map<TarmacSecurityExec>(createTarmacSecurityDto);
            _repository.CreateTarmacSecurityExec(tarmacSecurityModel);
            _repository.SaveChanges();

            var readTarmacSecurityDto = _mapper.Map<ReadTarmacSecurityDto>(tarmacSecurityModel);

            return CreatedAtRoute(nameof(GetTarmacSafetyExecById), new {Id = readTarmacSecurityDto.Id}, readTarmacSecurityDto);
        }
    }
}
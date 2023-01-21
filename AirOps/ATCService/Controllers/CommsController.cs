using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ATCService.Data;
using ATCService.Dtos;
using ATCService.Models;

namespace ATCService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommsController : ControllerBase
    {
        private readonly ICommsRepo _repository;
        private readonly IMapper _mapper;

        public CommsController(ICommsRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ReadCommsDto>> GetCommsDto()
        {
            Console.WriteLine(" --> Getting Comms Data... ");
            var commsItems = _repository.GetAllComms();
            return Ok(_mapper.Map<IEnumerable<ReadCommsDto>>(commsItems));
        }

        [HttpGet("{id}", Name = "GetCommsDataById")]
        public ActionResult<ReadCommsDto> GetCommsDataById(int id)
        {
            var commsItem = _repository.GetCommsById(id);
            if(commsItem != null)
            {
                return Ok(_mapper.Map<ReadCommsDto>(commsItem));
            }

            return NotFound();
        }

        [HttpPost]
        public ActionResult<ReadCommsDto> CreateComms(CreateCommsDto createCommsDto)
        {
            var commsModel = _mapper.Map<Comms>(createCommsDto);
            _repository.CreateComms(commsModel);
            _repository.SaveChanges();

            var readCommsDto = _mapper.Map<ReadCommsDto>(commsModel);

            return CreatedAtRoute(nameof(GetCommsDataById), new {Id = readCommsDto.Id}, readCommsDto);
        }
    }
}
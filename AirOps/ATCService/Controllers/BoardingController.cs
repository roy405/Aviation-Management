using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ATCService.Data;
using ATCService.Dtos;
using ATCService.Models;

namespace ATCService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoardingController : ControllerBase
    {
        private readonly IBoardingRepo _repository;
        private readonly IMapper _mapper;

        public BoardingController(IBoardingRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ReadBoardingDto>> GetBoardingData()
        {
            Console.WriteLine(" --> Getting Boarding Data... ");
            var boardingItems = _repository.GetAllBoardings();
            return Ok(_mapper.Map<IEnumerable<ReadBoardingDto>>(boardingItems));
        }

        [HttpGet("{id}", Name = "GetBoardingDataById")]
        public ActionResult<ReadBoardingDto> GetBoardingDataById(int id)
        {
            var boardingItem = _repository.GetBoardingById(id);
            if(boardingItem != null)
            {
                return Ok(_mapper.Map<ReadBoardingDto>(boardingItem));
            }

            return NotFound();
        }

        [HttpPost]
        public ActionResult<ReadBoardingDto> CreateBoarding(CreateBoardingDto createBoardingDto)
        {
            var boardingModel= _mapper.Map<Boarding>(createBoardingDto);
            _repository.CreateBoarding(boardingModel);
            _repository.SaveChanges();

            var boardingReadDto = _mapper.Map<ReadBoardingDto>(boardingModel);

            return CreatedAtRoute(nameof(GetBoardingDataById), new {Id = boardingReadDto.Id}, boardingReadDto);
        }
    }
}
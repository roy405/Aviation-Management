using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using AFTNService.Data;
using AFTNService.Dtos;
using AFTNService.Models;

namespace AFTNService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightPlanController : ControllerBase
    {
        private readonly IFlightPlanRepo _repository;

        private readonly IMapper _mapper;

        public FlightPlanController(IFlightPlanRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ReadFlightPlanDto>> GetFlightPlan()
        {
            Console.WriteLine(" --> Getting all FlightPlans... ");
            var flightPlanItems = _repository.GetAllFlightPlans();
            return Ok(_mapper.Map<IEnumerable<ReadFlightPlanDto>>(flightPlanItems));
        }

        [HttpGet("{id}", Name = "GetFlightPlanById")]
        public ActionResult<ReadFlightPlanDto> GetFlightPlanById(int id)
        {
            var flightPlanItem = _repository.GetFlightPlanById(id);
            if(flightPlanItem != null)
            {
                return Ok(_mapper.Map<ReadFlightPlanDto>(flightPlanItem));
            }
            return NotFound();
        }

        [HttpPost]
        public ActionResult<ReadFlightPlanDto> CreateFlightPlan(CreateFlightPlanDto createFlightPlanDto)
        {
            var flightPlanModel= _mapper.Map<FlightPlan>(createFlightPlanDto);
            _repository.CreateFlightPlan(flightPlanModel);
            _repository.SaveChanges();

            var flightPlanReadDto = _mapper.Map<ReadFlightPlanDto>(flightPlanModel);

            return CreatedAtRoute(nameof(GetFlightPlanById), new {Id = flightPlanReadDto.Id}, flightPlanReadDto);
        }
        
    }
}

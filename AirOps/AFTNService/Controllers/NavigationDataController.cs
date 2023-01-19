using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using AFTNService.Data;
using AFTNService.Dtos;
using AFTNService.Models;

namespace AFTNService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NavigationDataController : ControllerBase
    {
        private readonly INavigationDataRepo _repository;

        private readonly IMapper _mapper;

        public NavigationDataController(INavigationDataRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

         [HttpGet]
        public ActionResult<IEnumerable<ReadNavDataDto>> GetAllNavData()
        {
            Console.WriteLine(" --> Getting all Navigation... ");
            var navDataItems = _repository.GetAllNavigationData();
            return Ok(_mapper.Map<IEnumerable<ReadNavDataDto>>(navDataItems));
        }

        [HttpGet("{id}", Name = "GetNavDataById")]
        public ActionResult<ReadNavDataDto> GetNavDataById(int id)
        {
            var navDataItem = _repository.GetNavigationDataById(id);
            if(navDataItem != null)
            {
                return Ok(_mapper.Map<ReadNavDataDto>(navDataItem));
            }
            return NotFound();
        }

        [HttpPost]
        public ActionResult<ReadNavDataDto> CreateNavData(CreateNavDataDto createNavDataDto)
        {
            var navDataModel= _mapper.Map<NavigationData>(createNavDataDto);
            _repository.CreateNavigationData(navDataModel);
            _repository.SaveChanges();

            var navDataReadDto = _mapper.Map<ReadNavDataDto>(navDataModel);

            return CreatedAtRoute(nameof(GetNavDataById), new {Id = navDataReadDto.Id}, navDataReadDto);
        }
    }
}
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using Service.Abstract;

namespace WebAPI.Controllers
{

    [Route("[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        ICarService _carService;
        public CarController(ICarService carService)
        {
            _carService = carService;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var res = _carService.SearchDetails(new CarSearch());

            if (res.IsSucces)
            {
                return Ok(res.Data);
            }

            return BadRequest(res.Message);
        }

        [HttpPost]
        public IActionResult Post(Car car)
        {
            var res = _carService.Add(car);
            if (res.IsSucces)
            {
                return Ok(res.Message);
            }

            return BadRequest(res.Message);
        }
    }
}

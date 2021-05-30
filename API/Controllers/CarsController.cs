using BLL.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        ICarCervice _carService;
        public CarsController(ICarCervice carCervice)
        {
            _carService = carCervice;
        }
        [HttpGet("get-all")]
        public IActionResult GetAll()
        {
            var result = _carService.GetAll();
            if (result.Success)
            {

                return Ok(result);

            }
            return BadRequest(result);

        }
    }
}

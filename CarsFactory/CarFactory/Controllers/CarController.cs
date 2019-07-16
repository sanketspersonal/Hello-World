using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CarsInterfaces;

namespace CarFactory.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        ICarsProvider _carsProvider;

        public CarController(ICarsProvider carsProvider)
        {
            _carsProvider = carsProvider;
        }

        [HttpGet("{CarBrand}")]
        public List<string> GetCarDetails(string CarBrand)
        {
            return _carsProvider.GetCarDetails(CarBrand);
        }
    }
}
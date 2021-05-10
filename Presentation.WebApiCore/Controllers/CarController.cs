using CF.Application.Contracts.Car;
using CF.Application.Contracts.CarType;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentation.WebApiCore.Controllers
{
    public class CarController : Controller
    {
        private readonly ICarApplication _carApplication;

        public CarController(ICarApplication carApplication)
        {
            _carApplication = carApplication;
        }

        [HttpGet]
        public IEnumerable<CarViewModel> Cars()
        {
            return _carApplication.GetAll();
        }

        [HttpPost]
        public void Add([FromBody] CreateCar createCar)
        {
            _carApplication.Create(createCar);
        }

        [HttpPost]
        public void Remove([FromQuery] int id)
        {
            _carApplication.Remove(id);
        }
    }
}

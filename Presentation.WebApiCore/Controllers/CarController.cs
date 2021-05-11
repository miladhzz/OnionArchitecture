using CF.Application.Contracts.Car;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

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

        [HttpGet]
        public CarViewModel Get([FromQuery] int id)
        {
            return _carApplication.Get(id);
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

        [HttpPost]
        public void Activate([FromQuery] int id)
        {
            _carApplication.Activate(id);
        }

        [HttpPost]
        public void Rename([FromBody] RenameCar car)
        {
            _carApplication.Rename(car);
        }
    }
}

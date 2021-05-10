using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using CF.Application.Contracts.CarType;

namespace Presentation.WebApiCore.Controllers
{
    public class CarTypeController : Controller
    {
        private readonly ICarTypeApplication _carTypeApp;

        public CarTypeController(ICarTypeApplication carTypeApp)
        {
            _carTypeApp = carTypeApp;
        }

        [HttpGet]
        public IEnumerable<CarTypeViewModel> GetCarType()
        {
            return _carTypeApp.GetAll();
        }

        [HttpPost]
        public void Add([FromBody] CarTypeCreate carType)
        {
            _carTypeApp.Create(carType);
        }

        [HttpPost]
        public void Update([FromBody] CarTypeRename carType)
        {
            _carTypeApp.Rename(carType);
        }
    }
}

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

        [HttpGet]
        public ActionResult<CarTypeViewModel> Get([FromQuery] int id)
        {
            var result =  _carTypeApp.Get(id);

            if (result is null)
                return NotFound();

            return result;
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

        [HttpPost]
        public void Remove([FromQuery] int id)
        {
            _carTypeApp.Remove(id);
        }

        [HttpPost]
        public void Activate([FromQuery] int id)
        {
            _carTypeApp.Activate(id);
        }

    }
}

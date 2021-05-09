using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using CF.Application.Contracts.CarType;

namespace Presentation.WebApiCore.Controllers
{
    //[ApiController]
    [Route("api/[controller]")]
    public class CarTypeController : Controller
    {
        private readonly ICarTypeApplication _carTypeApp;

        public CarTypeController(ICarTypeApplication carTypeApp)
        {
            _carTypeApp = carTypeApp;
        }

        [HttpGet]
        
        public IEnumerable<CarTypeViewModel> Get()
        {
            return _carTypeApp.GetAll();
        }

    }
}

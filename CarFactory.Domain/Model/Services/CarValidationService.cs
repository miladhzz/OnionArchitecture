using CarFactory.Domain.Model.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarFactory.Domain.Model.Services
{
    public class CarValidationService : ICarValidationService
    {
        private readonly ICarRepository _carRepository;

        public CarValidationService(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public void CheckCarModelIsExist(string model)
        {
            if (_carRepository.Exist(model))
                throw new DuplicateCarException("Model is exists");
        }
    }
}

using CarFactory.Domain;
using CarFactory.Domain.Model;
using CarFactory.Domain.Model.Services;
using CF.Application.Contracts;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CF.Application
{
    public class CarApplication : ICarApplication
    {
        private readonly ICarRepository _carRepository;
        private readonly ICarValidationService _carValidationService;

        public CarApplication(ICarRepository carRepository, ICarValidationService carValidationService)
        {
            _carRepository = carRepository;
            _carValidationService = carValidationService;
        }

        public void Activate(int id)
        {
            var car = _carRepository.Get(id);
            car.Remove();
            _carRepository.Save();
        }

        public void Create(CreateCar command)
        {
            var newCar = new Car(command.Model, _carValidationService);
            _carRepository.Create(newCar);            
        }

        public RenameCar Get(int id)
        {
            var car = _carRepository.Get(id);
            return new RenameCar()
            {
                Id = car.Id,
                Model = car.Model,
            };
        }

        public List<CarViewModel> List()
        {
            var cars = _carRepository.GetAll();
            var result = new List<CarViewModel>();

            foreach (var car in cars)
            {
                result.Add(new CarViewModel()
                {
                    Id = car.Id,
                    Createtime = car.Createtime.ToString(CultureInfo.InvariantCulture),
                    IsDelete = car.IsDelete,
                    Model = car.Model
                });
            }

            return result;
        }

        public void Remove(int id)
        {
            var car = _carRepository.Get(id);
            car.Activate();
            _carRepository.Save();
        }

        public void Rename(RenameCar command)
        {
            var car = _carRepository.Get(command.Id);
            car.Rename(command.Model);
            _carRepository.Save();
        }
    }
}

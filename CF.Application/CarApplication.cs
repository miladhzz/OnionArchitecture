using CarFactory.Domain.CarDomain;
using CarFactory.Domain.CarDomain.Services;
using CF.Application.Contracts.Car;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

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
            car.Activate();
            _carRepository.Save();
        }

        public CarViewModel CarInfo(int id)
        {
            var car = _carRepository.CarInfo(id);
            return new CarViewModel()
            {
                Id = car.Id,
                Model = car.Model,
                CreateTime = car.CreateTime.ToString(CultureInfo.InvariantCulture),
                IsDelete = car.IsDeleted,
                CarType = car.CarType.Name
            };
        }

        public void Create(CreateCar command)
        {
            var newCar = new Car(command.Model, command.CarTypeId, _carValidationService);
            _carRepository.Create(newCar);            
        }

        public Car Get(int id)
        {
            return _carRepository.Get(id);
        }

        public List<CarViewModel> GetAll()
        {
            var cars = _carRepository.GetActiveCars();
            return (from car in cars
                    select new CarViewModel()
                    {
                        Id = car.Id,
                        CreateTime = car.CreateTime.ToString(CultureInfo.InvariantCulture),
                        IsDelete = car.IsDeleted,
                        Model = car.Model,
                        CarType = car.CarType.Name
                    }).ToList();
        }

        public void Remove(int id)
        {
            var car = _carRepository.Get(id);
            car.Remove();
            _carRepository.Save();
        }

        public void Rename(RenameCar command)
        {
            var car = _carRepository.Get(command.Id);
            car.Rename(command.Model);
            _carRepository.Save();
        }

        CarViewModel ICarApplication.Get(int id)
        {
            var car = _carRepository.CarInfo(id);
            return new CarViewModel()
            {
                Id = car.Id,
                Model = car.Model,
                CreateTime = car.CreateTime.ToString(CultureInfo.InvariantCulture),
                IsDelete = car.IsDeleted,
            };
        }
    }
}

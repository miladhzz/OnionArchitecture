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
            car.Remove();
            _carRepository.Save();
        }

        public void Create(CreateCar command)
        {
            var newCar = new Car(command.Model, _carValidationService);
            _carRepository.Create(newCar);            
        }

        public CarViewModel Get(int id)
        {
            var car = _carRepository.Get(id);
            return new CarViewModel()
            {
                Id = car.Id,
                Model = car.Model,
                Createtime = car.Createtime.ToString(CultureInfo.InvariantCulture),
                IsDelete = car.IsDelete
            };
        }

        public List<CarViewModel> List()
        {
            var cars = _carRepository.GetAll();
            return (from car in cars
                    select new CarViewModel()
                    {
                        Id = car.Id,
                        Createtime = car.Createtime.ToString(CultureInfo.InvariantCulture),
                        IsDelete = car.IsDelete,
                        Model = car.Model
                    }).ToList();
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

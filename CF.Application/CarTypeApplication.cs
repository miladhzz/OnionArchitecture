using CarFactory.Domain.CarTypeDomain;
using CF.Application.Contracts.CarType;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace CF.Application
{
    public class CarTypeApplication : ICarTypeApplication
    {
        private readonly ICarTypeRepository _carTypeRepository;

        public CarTypeApplication(ICarTypeRepository arTypeRepository)
        {
            _carTypeRepository = arTypeRepository;
        }

        public void Activate(int id)
        {
            var car = _carTypeRepository.Get(id);
            car.Activate();
            _carTypeRepository.Save();
        }

        public void Create(CarTypeCreate command)
        {
            var carType = new CarType(command.Name);
            _carTypeRepository.Create(carType);
        }

        public CarTypeViewModel Get(int id)
        {
            var carType = _carTypeRepository.Get(id);
            return new CarTypeViewModel()
            {
                Id = carType.Id,
                CreateTime = carType.CreateTime.ToString(CultureInfo.InvariantCulture),
                Name = carType.Name,
                IsDeleted = carType.IsDeleted
            };
        }

        public List<CarTypeViewModel> GetAll()
        {
            var carTypes = _carTypeRepository.GetAll();
            return (from carType in carTypes
                    select new CarTypeViewModel()
                    {
                        Id = carType.Id,
                        CreateTime = carType.CreateTime.ToString(CultureInfo.InvariantCulture),
                        IsDeleted = carType.IsDeleted,
                        Name = carType.Name
                    }).ToList();
        }

        public void Remove(int id)
        {
            var car = _carTypeRepository.Get(id);
            car.Remove();
            _carTypeRepository.Save();
        }

        public void Rename(CarTypeRename command)
        {
            var carType = _carTypeRepository.Get(command.Id);
            carType.Rename(command.Name);
            _carTypeRepository.Save();
        }
    }
}

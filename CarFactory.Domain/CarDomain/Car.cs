using CarFactory.Domain.CarDomain.Services;
using CarFactory.Domain.CarTypeDomain;
using CarFactory.Generics;
using System;

namespace CarFactory.Domain.CarDomain
{
    public class Car : DomainBase<int>
    {
        public string Model { get; private set; }
        public int CarTypeId { get; private set; }
        public CarType CarType { get; private set; }
        public bool IsDeleted { get; private set; }

        public Car()
        {

        }

        public Car(string model, int carTypeId, ICarValidationService carValidatorService)
        {
            CheckModelIsEmpty(model);
            carValidatorService.CheckCarModelIsExist(model);

            Model = model;
            CarTypeId = carTypeId;
            IsDeleted = false;
        }

        public void Rename(string model)
        {
            CheckModelIsEmpty(model);

            Model = model;
        }

        public void Remove()
        {
            IsDeleted = true;
        }

        public void Activate()
        {
            IsDeleted = false;
        }
        private void CheckModelIsEmpty(string model)
        {
            if (string.IsNullOrEmpty(model))
                throw new Exception("model is empty");
        }
    }
}

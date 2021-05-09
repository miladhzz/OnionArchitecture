using CarFactory.Domain.CarDomain.Services;
using CarFactory.Domain.CarTypeDomain;
using System;

namespace CarFactory.Domain.CarDomain
{
    public class Car
    {
        public int Id { get; private set; }
        public string Model { get; private set; }
        public DateTime CreateTime { get; private set; }
        public bool IsDeleted { get; private set; }
        public int CarTypeId { get; private set; }
        public CarType CarType { get; private set; }

        public Car(string model, ICarValidationService icaarValidatorService)
        {
            CheckModelIsEmpty(model);
            icaarValidatorService.CheckCarModelIsExist(model);

            Model = model;
            IsDeleted = false;
            CreateTime = DateTime.Now;
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

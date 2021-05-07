using CarFactory.Domain.CarDomain.Services;
using System;

namespace CarFactory.Domain.CarDomain
{
    public class Car
    {
        public int Id { get; private set; }
        public string Model { get; private set; }
        public DateTime Createtime { get; private set; }
        public bool IsDelete { get; private set; }

        public Car(string model, ICarValidationService icaarValidatorService)
        {
            CheckModelIsEmpty(model);
            icaarValidatorService.CheckCarModelIsExist(model);

            Model = model;
            IsDelete = false;
            Createtime = DateTime.Now;
        }

        public void Rename(string model)
        {
            CheckModelIsEmpty(model);

            Model = model;
        }

        public void Remove()
        {
            IsDelete = true;
        }

        public void Activate()
        {
            IsDelete = false;
        }
        private void CheckModelIsEmpty(string model)
        {
            if (string.IsNullOrEmpty(model))
                throw new Exception("model is empty");
        }
    }
}

using CarFactory.Domain.CarDomain;
using System;
using System.Collections;
using System.Collections.Generic;

namespace CarFactory.Domain.CarTypeDomain
{
    public class CarType
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public bool IsDeleted { get; private set; }
        public DateTime CreateTime { get; private set; }
        public ICollection<Car> Cars { get; set; }

        public CarType()
        {

        }
        public CarType(string name)
        {
            Name = name;
            IsDeleted = false;
            CreateTime = DateTime.Now;
            Cars = new List<Car>();
        }
        public void Rename(string name)
        {
            Name = name;
        }
        public void Remove()
        {
            IsDeleted = true;
        }
        public void Activate()
        {
            IsDeleted = true;
        }
    }
}

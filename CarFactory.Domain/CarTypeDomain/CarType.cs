using CarFactory.Domain.CarDomain;
using CarFactory.Generics;
using System;
using System.Collections.Generic;

namespace CarFactory.Domain.CarTypeDomain
{
    public class CarType : DomainBase<int>
    {
        public string Name { get; private set; }
        public ICollection<Car> Cars { get; set; }
        public bool IsDeleted { get; private set; }

        public CarType()
        {

        }
        public CarType(string name)
        {
            Name = name;
            IsDeleted = false;
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
            IsDeleted = false;
        }
    }
}

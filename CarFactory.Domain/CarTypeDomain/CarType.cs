using System;

namespace CarFactory.Domain.CarTypeDomain
{
    public class CarType
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public bool IsDeleted { get; private set; }
        public DateTime CreateTime { get; private set; }

        public CarType()
        {

        }
        public CarType(string name)
        {
            Name = name;
            IsDeleted = false;
            CreateTime = DateTime.Now;
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

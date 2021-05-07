using CarFactory.Domain.CarDomain;
using System.Collections.Generic;

namespace CarFactory.Domain.CarTypeDomain
{
    public interface ICarTypeRepository
    {
        void Create(Car entity);
        List<Car> GetAll();
        Car Get(int id);
        bool Exist(string name);

    }
}

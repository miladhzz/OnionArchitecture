using CarFactory.Domain.CarDomain;
using System.Collections.Generic;

namespace CarFactory.Domain.CarTypeDomain
{
    public interface ICarTypeRepository
    {
        void Create(CarType entity);
        List<CarType> GetAll();
        CarType Get(int id);
        bool Exist(string name);
        void Save();

    }
}

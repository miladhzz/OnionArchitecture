using System.Collections.Generic;

namespace CarFactory.Domain.CarDomain
{
    public interface ICarRepository
    {
        void Create(Car entity);
        List<Car> GetAll();
        Car Get(int id);
        void Save();
        bool Exist(string model);
    }
}

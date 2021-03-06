using CarFactory.Generics.Infrastructure;
using System.Collections.Generic;

namespace CarFactory.Domain.CarDomain
{
    public interface ICarRepository : IRepository<int , Car>
    {
        List<Car> GetActiveCars();
        Car CarInfo(int id);
    }
}

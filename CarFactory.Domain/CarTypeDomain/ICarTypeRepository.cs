using CarFactory.Generics.Infrastructure;
using System.Collections.Generic;

namespace CarFactory.Domain.CarTypeDomain
{
    public interface ICarTypeRepository : IRepository<int, CarType>
    {
        List<CarType> GetActiveCarTypes();
    }
}

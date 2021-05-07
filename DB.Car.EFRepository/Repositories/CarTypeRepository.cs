using CarFactory.Domain.CarDomain;
using CarFactory.Domain.CarTypeDomain;
using DB.EFRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace DB.Infrastructure.EFRepository.Repositories
{
    public class CarTypeRepository : ICarTypeRepository
    {
        public readonly CarFactoryContext _context;

        public CarTypeRepository(CarFactoryContext context)
        {
            _context = context;
        }

        public void Create(Car entity)
        {
            throw new NotImplementedException();
        }

        public bool Exist(string name)
        {
            throw new NotImplementedException();
        }

        public Car Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}

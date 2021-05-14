using CarFactory.Domain.CarTypeDomain;
using DB.EFRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DB.Infrastructure.EFRepository.Repositories
{
    public class CarTypeRepository : ICarTypeRepository
    {
        private readonly CarFactoryContext _context;

        public CarTypeRepository(CarFactoryContext context)
        {
            _context = context;
        }

        public void Create(CarType entity)
        {
            _context.CarTypes.Add(entity);
            Save();
        }

        public bool Exist(Expression<Func<CarType, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public CarType Get(int id)
        {
            return _context.CarTypes.FirstOrDefault(x => x.Id == id);
        }

        public List<CarType> GetAll()
        {
            return _context.CarTypes.Where(x => !x.IsDeleted).ToList();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}

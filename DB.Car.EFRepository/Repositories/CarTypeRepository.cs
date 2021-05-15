using CarFactory.Domain.CarTypeDomain;
using CarFactory.Generics.Infrastructure;
using DB.EFRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DB.Infrastructure.EFRepository.Repositories
{
    public class CarTypeRepository : BaseRepository<int, CarType>, ICarTypeRepository
    {
        private readonly CarFactoryContext _context;

        public CarTypeRepository(CarFactoryContext context) : base(context)
        {
            _context = context;
        }


        //public bool Exist(Expression<Func<CarType, bool>> expression)
        //{
        //    throw new NotImplementedException();
        //}


        public List<CarType> GetActiveCarTypes()
        {
            return _context.CarTypes.Where(x => !x.IsDeleted).ToList();
        }
    }
}

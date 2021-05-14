using System.Collections.Generic;
using System.Linq;
using CarFactory.Domain.CarDomain;
using CarFactory.Generics.Infrastructure;
using DB.EFRepository;
using Microsoft.EntityFrameworkCore;

namespace DB.Infrastructure.EFRepository.Repositories
{
    public class CarRepository : BaseRepository<int, Car>, ICarRepository
    {
        private readonly CarFactoryContext _context;

        public CarRepository(CarFactoryContext context) : base(context)
        {
            _context = context;
        }

        public Car CarInfo(int id)
        {
            return _context.Cars.Include(x => x.CarType).FirstOrDefault(x => x.Id == id);
        }

        //public bool Exist(string model)
        //{
        //    return true;
        //    //return _context.Cars.Any(x => x.Model == model);
        //}


        public List<Car> GetActiveCars()
        {
            return _context.Cars.Include(x => x.CarType).Where(x => !x.IsDeleted).ToList();
        }

        

    }
}

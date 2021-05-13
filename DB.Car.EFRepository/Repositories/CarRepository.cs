using System.Collections.Generic;
using System.Linq;
using CarFactory.Domain.CarDomain;
using DB.EFRepository;
using Microsoft.EntityFrameworkCore;

namespace DB.Infrastructure.EFRepository.Repositories
{
    public class CarRepository : ICarRepository
    {
        private readonly CarFactoryContext _context;

        public CarRepository(CarFactoryContext carFactoryContext)
        {
            _context = carFactoryContext;
        }

        public void Create(Car entity)
        {
            _context.Cars.Add(entity);
            Save();
        }

        public bool Exist(string model)
        {
            return _context.Cars.Any(x => x.Model == model);
        }

        public Car Get(int id)
        {
            return _context.Cars.Include(x => x.CarType).FirstOrDefault(x => x.Id == id);
        }

        public List<Car> GetAll()
        {
            return _context.Cars.Include(x => x.CarType).Where(x => !x.IsDeleted).ToList();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

    }
}

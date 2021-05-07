using CarFactory.Domain.CarDomain;
using System.Collections.Generic;
using System.Linq;

namespace DB.EFRepository
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
            _context.Add(entity);
            Save();
        }

        public bool Exist(string model)
        {
            return _context.Cars.Any(x => x.Model == model);
        }

        public Car Get(int id)
        {
            return _context.Cars.FirstOrDefault(x => x.Id == id);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        List<Car> ICarRepository.GetAll()
        {
            return _context.Cars.ToList();
        }
    }
}

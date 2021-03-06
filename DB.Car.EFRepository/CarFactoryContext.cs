using CarFactory.Domain.CarDomain;
using CarFactory.Domain.CarTypeDomain;
using DB.Infrastructure.EFRepository.Mapping;
using Microsoft.EntityFrameworkCore;

namespace DB.EFRepository
{
    public class CarFactoryContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<CarType> CarTypes { get; set; }
        public CarFactoryContext(DbContextOptions<CarFactoryContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CarsMapping());
            modelBuilder.ApplyConfiguration(new CarTypeMapping());

            base.OnModelCreating(modelBuilder);
        }
    }
}

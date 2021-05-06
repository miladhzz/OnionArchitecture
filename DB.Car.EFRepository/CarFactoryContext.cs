using CarFactory.Domain.Model;
using DB.EFRepository.Mapping;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DB.EFRepository
{
    public class CarFactoryContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }

        public CarFactoryContext(DbContextOptions<CarFactoryContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CarsMapping());
            base.OnModelCreating(modelBuilder);
        }
    }
}

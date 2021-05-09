using CarFactory.Domain.CarDomain;
using CarFactory.Domain.CarTypeDomain;
using CF.Application;
using CF.Application.Contracts.Car;
using CF.Application.Contracts.CarType;
using DB.EFRepository;
using DB.Infrastructure.EFRepository.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace EF.Infrastructure.Core
{
    public class Config
    {
        public void WireUp(IServiceCollection services, string connectionString)
        {
            services.AddTransient<ICarApplication, CarApplication>();
            services.AddTransient<ICarRepository, CarRepository>();

            services.AddTransient<ICarTypeRepository, CarTypeRepository>();
            services.AddTransient<ICarTypeApplication, CarTypeApplication>();

            services.AddDbContext<CarFactoryContext>(options => options.UseSqlServer(connectionString));

        }
    }
}

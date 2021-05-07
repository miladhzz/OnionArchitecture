using CarFactory.Domain.CarDomain;
using CF.Application;
using CF.Application.Contracts;
using DB.EFRepository;
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

            services.AddDbContext<CarFactoryContext>(options => options.UseSqlServer(connectionString));

        }
    }
}

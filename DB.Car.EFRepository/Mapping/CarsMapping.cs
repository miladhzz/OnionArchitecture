using CarFactory.Domain.CarDomain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DB.Infrastructure.EFRepository.Mapping
{
    public class CarsMapping : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.ToTable("Cars");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Model);
            builder.Property(x => x.IsDeleted);
            builder.Property(x => x.CreateTime);

            builder.HasOne(x => x.CarType).WithMany(x => x.Cars).HasForeignKey(x => x.CarTypeId);
        }
    }
}

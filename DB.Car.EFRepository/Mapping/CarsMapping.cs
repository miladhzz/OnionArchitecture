using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CarFactory.Domain.Model;

namespace DB.EFRepository.Mapping
{
    public class CarsMapping : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.ToTable("Car");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Model);
            builder.Property(x => x.IsDelete);
            builder.Property(x => x.Createtime);


        }
    }
}

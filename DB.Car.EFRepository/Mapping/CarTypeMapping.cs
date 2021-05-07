using CarFactory.Domain.CarTypeDomain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DB.Infrastructure.EFRepository.Mapping
{
    public class CarTypeMapping : IEntityTypeConfiguration<CarType>
    {
        public void Configure(EntityTypeBuilder<CarType> builder)
        {
            builder.ToTable("CarTypes");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name);
            builder.Property(x => x.IsDeleted);
            builder.Property(x => x.CreateTime);

            builder.HasMany(x => x.Cars).WithOne(x => x.CarType).HasForeignKey(x => x.CarTypeId);
        }
    }
}

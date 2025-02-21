using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Mapping;

internal class StatusInspectionMap : IEntityTypeConfiguration<StatusInspection>
{
  public void Configure(EntityTypeBuilder<StatusInspection> builder)
  {
    builder.ToTable("StatusInspections");

    builder.Property(prop => prop.Id)
      .HasConversion(prop => prop.ToString(), prop => new Guid(prop));
    
    builder.Property(prop => prop.IdNextStatus)
      .HasConversion(prop => prop.ToString(), prop => new Guid(prop!));

    builder.Property(prop => prop.IdErrorStatus)
      .HasConversion(prop => prop.ToString(), prop => new Guid(prop!));
  }
}

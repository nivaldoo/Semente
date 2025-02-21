using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Mapping;

internal class InspectionMap : BaseMap<Inspection>
{
  public override void Configure(EntityTypeBuilder<Inspection> builder)
  {
    base.Configure(builder);
    
    builder.ToTable("Inspections");

    builder.HasOne(prop => prop.StatusInspection)
      .WithMany(prop => prop.Inspections)
      .HasForeignKey(e => e.IdStatusInspection)
      .IsRequired();
  }
}

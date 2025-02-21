using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Domain.Entities;

namespace Infrastructure.Mapping;

internal class BaseMap<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : BaseEntity
{
  public virtual void Configure(EntityTypeBuilder<TEntity> builder)
  {
    builder.HasKey(prop => prop.Id);

    builder.Property(prop => prop.Id)
            .HasConversion(prop => prop.ToString(), prop => new Guid(prop));

    builder.Property(prop => prop.CreatedAt)
            .HasColumnType("datetime")
            .IsRequired();

    builder.Property(prop => prop.CreatedAt);

    builder.Property(prop => prop.IdCreateUser)
            .HasColumnType("char(36)")
            .IsRequired();

    builder.Property(prop => prop.UpdatedAt)
            .HasColumnType("datetime");

    builder.Property(prop => prop.IdUpdateUser)
            .HasColumnType("char(36)");

    builder.HasQueryFilter(x => x.IsDeleted == false);
  }
}

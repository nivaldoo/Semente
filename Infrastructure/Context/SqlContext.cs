using Domain.Entities;
using Infrastructure.Mapping;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Context;

public class SqlContext : DbContext
{
  public SqlContext(DbContextOptions<SqlContext> options) : base(options)
  {
  }
  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    modelBuilder.Entity<StatusInspection>(new StatusInspectionMap().Configure);
    modelBuilder.Entity<Inspection>(new InspectionMap().Configure);
  }
}

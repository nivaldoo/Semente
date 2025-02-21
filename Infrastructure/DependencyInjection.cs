using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Domain.Interfaces;
using Infrastructure.Context;

namespace Infrastructure;

public static class DependencyInjection
{
  public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
  {
    // services.AddMediatR(scan => scan.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

    services.AddDbContext<SqlContext>(options => options.UseSqlServer(configuration.GetConnectionString("SQLConnection"), b => b.MigrationsAssembly(typeof(SqlContext).Assembly.FullName)));

    services.AddScoped<SqlContext>();

    services.AddScoped<IUnitOfWork, UnitOfWork>();

    return services;
  }
}

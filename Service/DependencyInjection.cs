using Domain.Interfaces.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RInspection.Service.Services;
using Service.Services;

namespace Service;

public static class DependencyInjection
{
  public static IServiceCollection AddService(this IServiceCollection services, IConfiguration configuration)
  {
    services.AddScoped(typeof(IBaseService<>), typeof(BaseService<>));
    services.AddScoped(typeof(IBaseListService<>), typeof(BaseListService<>));
    services.AddScoped<IStatusInspectionService, StatusInspectionsService>();
    services.AddScoped<IInspectionService, InspectionService>();

    return services;
  }
}

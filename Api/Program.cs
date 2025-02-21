using Infrastructure;
using Service;

var builder = WebApplication.CreateBuilder(args);
{
  builder.Services.AddInfrastructure(builder.Configuration);
  builder.Services.AddService(builder.Configuration);
  builder.Services.AddControllers();
}

var app = builder.Build();
{
  // app.UseHttpsRedirection();
  app.MapControllers();

  app.Run();
}

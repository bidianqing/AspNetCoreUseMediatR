using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddMediatR(xfg =>
{
    xfg.RegisterServicesFromAssemblies(Assembly.Load("Domain"), Assembly.Load("AspNetCoreUseMediatR"));
});
var app = builder.Build();

// Configure the HTTP request pipeline.
app.MapControllers();
app.Run();

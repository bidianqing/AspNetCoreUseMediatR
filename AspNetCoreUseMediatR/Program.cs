using Domain.Commands.GitHub;
using Infrastructure.GitHub;
using MediatR;
using System.Reflection;
using System.Text.Json.Nodes;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddMediatR(xfg =>
{
    xfg.RegisterServicesFromAssemblies(Assembly.Load("Domain"), Assembly.Load("AspNetCoreUseMediatR"), Assembly.Load("Infrastructure"));
});

builder.Services.AddHttpClient("github", client =>
{
    client.DefaultRequestHeaders.Add("User-Agent", "PostmanRuntime/7.40.0");
});
var app = builder.Build();

// Configure the HTTP request pipeline.
app.MapControllers();
app.Run();

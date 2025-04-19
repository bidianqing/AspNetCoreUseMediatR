using MediatR.NotificationPublishers;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddMediatR(xfg =>
{
    xfg.RegisterServicesFromAssemblies(Assembly.Load("Domain"), Assembly.Load("AspNetCoreUseMediatR"), Assembly.Load("Infrastructure"));

    // https://www.milanjovanovic.tech/blog/building-a-better-mediatr-publisher-with-channels-and-why-you-shouldnt
    xfg.NotificationPublisherType = typeof(TaskWhenAllPublisher);
});

builder.Services.AddHttpClient("github", client =>
{
    client.DefaultRequestHeaders.Add("User-Agent", "PostmanRuntime/7.40.0");
});
var app = builder.Build();

// Configure the HTTP request pipeline.
app.MapControllers();
app.Run();

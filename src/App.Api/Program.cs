using App.Infrastructure;
using App.Application;
using App.Api;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddApplication();
builder.Services.AddApi();

var app = builder.Build();

app.MapGraphQL();

app.Run();

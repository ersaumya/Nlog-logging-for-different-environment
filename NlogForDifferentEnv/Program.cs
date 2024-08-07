using NLog;
using NlogForDifferentEnv.Extensions;

var builder = WebApplication.CreateBuilder(args);

var env=builder.Environment.EnvironmentName;

LogManager.Setup().LoadConfigurationFromFile(string.Concat(Directory.GetCurrentDirectory(),$"/nlog.{env}.config"));

// Add services to the container.

builder.Services.ConfigureLoggerService();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();

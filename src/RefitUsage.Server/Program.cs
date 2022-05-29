
using RefitUsage.Domain.Interfaces;
using RefitUsage.Domain.Interfaces.Repositories;
using RefitUsage.Proxy;
using RefitUsage.Services;
using RefitUsage.DataAccess.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Automapper
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

//External Services
builder.Services.RegisterUserServices();

//Internal Services
builder.Services.AddScoped<IWriter, WriterService>();

//Repo srvices
builder.Services.AddScoped<IWriterRepository, WriterRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

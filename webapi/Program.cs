using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Servicio de BBDD con MySql
//builder.Services.AddDbContext<AplicationDBContext>(options => options.UseMySql(Configuration.GetConnectionString("watchlistddbbconnection")));
builder.Services.AddDbContext<AplicationDBContext>(configuracion =>

    configuracion.UseMySql(
    builder.Configuration["ConnectionStrings:watchlistddbbconnection"],
    new MySqlServerVersion(new Version(8, 0, 30)) // O la versión de tu servidor MySQL
));


builder.Services.Configure<IdentityOptions>(options =>
options.Lockout.AllowedForNewUsers = false);

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

using Count.API.Context;
using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using MySqlConnector;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using MySqlConnection = MySql.Data.MySqlClient.MySqlConnection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<CountAPIDbContext>(options => options.UseMySql("Server=localhost;Port=3306;Database=recAPI_db;Uid=root;Pwd=root", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.31-mysql", ServerType.MySql)));

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

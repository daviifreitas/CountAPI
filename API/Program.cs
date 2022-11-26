using API.Context;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ApplicationContext>(options => options.UseMySql("Server=recnplay-server.mysql.database.azure.com;UserID = davifmelo;Password=password13258046A@;Database=recnPlayCountDatabase;", Microsoft.EntityFrameworkCore.ServerVersion.Parse("5.7.33-mysql", ServerType.MySql)));

builder.Services.AddCors();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(options => options.WithOrigins("https://apicountrecnplay.azurewebsites.net"));
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

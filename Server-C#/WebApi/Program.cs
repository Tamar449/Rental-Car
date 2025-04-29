using DAL.Models;
using Microsoft.EntityFrameworkCore;
using WebApi;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(o => o.AddPolicy("Allow All", opt=>opt.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin()));

builder.Services.AddScoped<I_DAL.I_DAL<DTO.CarModel_Dto>, DAL.CarModel>();
builder.Services.AddScoped<I_DAL.I_DAL_Car, DAL.Car>();
builder.Services.AddScoped<I_DAL.I_DAL<DTO.CarType_Dto>, DAL.CarType>();
builder.Services.AddScoped<I_DAL.I_DAL_DriveType, DAL.DriveType>();
builder.Services.AddScoped<I_DAL.I_DAL_Rental, DAL.Rental>();
builder.Services.AddScoped<I_DAL.I_DAL<DTO.Return_Dto>, DAL.Return>();
builder.Services.AddScoped<I_DAL.I_DAL<DTO.User_Dto>, DAL.User>();
builder.Services.AddScoped<I_DAL.I_DAL<DTO.UserType_Dto>, DAL.UserType>();

builder.Services.AddScoped<I_BLL.I_BLL<DTO.CarModel_Dto>, BLL.CarModel>();
builder.Services.AddScoped<I_BLL.I_BLL_Car, BLL.Car>();
builder.Services.AddScoped<I_BLL.I_BLL<DTO.CarType_Dto>, BLL.CarType>();
builder.Services.AddScoped<I_BLL.I_BLL_DriveType, BLL.DriveType>();
builder.Services.AddScoped<I_BLL.I_BLL_Rental, BLL.Rental>();
builder.Services.AddScoped<I_BLL.I_BLL<DTO.Return_Dto>, BLL.Return>();
builder.Services.AddScoped<I_BLL.I_BLL<DTO.User_Dto>, BLL.User>();
builder.Services.AddScoped<I_BLL.I_BLL<DTO.UserType_Dto>, BLL.UserType>();

//builder.Services.AddDbContext<RentalCarsContext>(options =>
//options.UseSqlServer(builder.Configuration.GetConnectionString("RentalCarsContext")));

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

app.UseCors("Allow All");

app.Run();

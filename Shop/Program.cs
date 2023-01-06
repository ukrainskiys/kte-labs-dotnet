using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Shop.Data;
using Shop.Data.Repositories;
using Shop.Models.Domain;
using Shop.Services;
using Shop.Services.Mapper;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddSingleton<ApplicationDbContext>();
builder.Services.AddAutoMapper(typeof(ShopMappingProfile));

builder.Services.AddSingleton<CustomerRepository>();
builder.Services.AddSingleton<ICustomerService, CustomerService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

// app.UseAuthorization();

app.MapControllers();

// var adc = app.Services.GetRequiredService<ApplicationDbContext>();
// adc.Customers.AddRange(
//     new Customer()
//     {
//         Name = "c-1"
//     },
//     new Customer
//     {
//         Name = "c-2",
//         IndividualDiscountFirst = 3,
//     },
//     new Customer()
//     {
//         Name = "c-3",
//         IndividualDiscountSecond = 6
//     },
//     new Customer()
//     {
//         Name = "c-4",
//         IndividualDiscountFirst = 4,
//         IndividualDiscountSecond = 10
//     }
// );
// adc.SaveChanges();

app.Run();
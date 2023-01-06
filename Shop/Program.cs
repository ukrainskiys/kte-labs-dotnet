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
builder.Services.AddSingleton<ProductRepository>();

builder.Services.AddSingleton<ICustomerService, CustomerService>();
builder.Services.AddSingleton<IProductService, ProductService>();


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
// adc.Products.AddRange(
//     new Product()
//     {
//         Name = "p-1",
//         Price = 99.99m
//     },
//     new Product
//     {
//         Price = 40m
//     },
//     new Product()
//     {
//         Name = "p-2",
//         Price = 199.99m
//     },
//     new Product()
//     {
//         Name = "p-3",
//         Price = 993.9m
//     }
// );
// adc.SaveChanges();

app.Run();
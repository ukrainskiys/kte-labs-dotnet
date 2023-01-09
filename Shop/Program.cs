using System.Reflection;
using Quartz;
using Shop.Data;
using Shop.Data.Repositories;
using Shop.Services;
using Shop.Services.Mapper;
using Shop.Services.Schedule;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddSingleton<ApplicationDbContext>();
builder.Services.AddAutoMapper(typeof(ShopMappingProfile));

builder.Services.AddSingleton<CustomerRepository>();
builder.Services.AddSingleton<ProductRepository>();
builder.Services.AddSingleton<RatingRepository>();
builder.Services.AddSingleton<SaleFactRepository>();

builder.Services.AddSingleton<ICustomerService, CustomerService>();
builder.Services.AddSingleton<IProductService, ProductService>();
builder.Services.AddSingleton<ISaleFactService, SaleFactService>();

builder.Services.AddQuartz(q =>
{
    q.UseMicrosoftDependencyInjectionJobFactory();
    q.AddJob<ProductDiscountGenerator>(opts => opts.WithIdentity(ProductDiscountGenerator.JobKey));
    q.AddTrigger(opts => opts
        .ForJob(ProductDiscountGenerator.JobKey)
        .WithIdentity($"{ProductDiscountGenerator.JobKey}-trigger")
        .WithCronSchedule("* * 0 * * *")
    );
});
builder.Services.AddQuartzHostedService(opts => opts.WaitForJobsToComplete = true);


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

app.MapControllers();

app.Run();
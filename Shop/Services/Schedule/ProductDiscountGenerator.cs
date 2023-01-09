using Microsoft.EntityFrameworkCore;
using Quartz;
using Shop.Data;

namespace Shop.Services.Schedule;

// ReSharper disable once ClassNeverInstantiated.Global
public class ProductDiscountGenerator : IJob
{
    public static readonly JobKey JobKey = new("ProductDiscountGenerator");
    private readonly ApplicationDbContext _db;

    public ProductDiscountGenerator(ApplicationDbContext applicationDbContext)
    {
        _db = applicationDbContext;
    }

    public Task Execute(IJobExecutionContext context)
    {
        Console.WriteLine("hello");
        var random = new Random(Seed: DateTime.Now.Millisecond);

        var ids = _db.Products.Select(selector: product => product.Id).ToList();
        var productId = ids[index: random.Next(maxValue: ids.Count)];
        var discount = random.Next(minValue: 5, maxValue: 11);

        _db.Database.ExecuteSqlAsync($"""
            START TRANSACTION;
            TRUNCATE TABLE "ProductDiscount";
            INSERT INTO "ProductDiscount" VALUES ({productId}, {discount});
            COMMIT;
         """);

        return Task.CompletedTask;
    }
}
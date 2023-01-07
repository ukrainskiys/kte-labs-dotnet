using Microsoft.EntityFrameworkCore;
using Shop.Models.Domain;

namespace Shop.Data.Repositories;

public class ProductRepository : RepositoryBase<Product>
{
    private readonly DbSet<Product> _products;
    
    public ProductRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
    {
        _products = applicationDbContext.Products;
    }

    public override Product? FindById(long id)
    {
        return _products.Find(id);
    }

    public override IEnumerable<Product> GetAll()
    {
        return _products.ToList();
    }

    public override DbSet<Product> GetDbSet()
    {
        return _products;
    }

    public override void Save(Product entity, params Product[] entities)
    {
        _products.Add(entity);
        _products.AddRange(entities);
        Db.SaveChangesAsync();
    }

    public List<Rating> GetRatingsByProductId(long productId)
    {
        return _products.Find(productId)?.Ratings.ToList() ?? new List<Rating>();
    }
}
using Shop.Models.Domain;

namespace Shop.Data.Repositories;

public class ProductRepository : RepositoryBase<Product>
{
    public ProductRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
    {
    }

    public List<Rating> GetRatingsByProductId(long productId)
    {
        return Set.Find(productId)?.Ratings.ToList() ?? new List<Rating>();
    }
}
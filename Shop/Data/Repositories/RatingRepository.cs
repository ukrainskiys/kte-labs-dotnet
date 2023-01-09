using Shop.Models.Domain;

namespace Shop.Data.Repositories;

public class RatingRepository : RepositoryBase<Rating>
{
    public RatingRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
    {
    }

    public Rating? FindByProductIdAndCustomerId(long productId, long customerId)
        => Set.FirstOrDefault(rating => rating.ProductId == productId && rating.CustomerId == customerId);
}
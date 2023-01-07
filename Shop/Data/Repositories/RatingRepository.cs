using Microsoft.EntityFrameworkCore;
using Shop.Models.Domain;

namespace Shop.Data.Repositories;

public class RatingRepository : RepositoryBase<Rating>
{
    private readonly DbSet<Rating> _ratings;

    public RatingRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
    {
        _ratings = applicationDbContext.Ratings;
    }

    public Rating? FindByProductIdAndCustomerId(long productId, long customerId)
        => _ratings.FirstOrDefault(rating => rating.ProductId == productId && rating.CustomerId == customerId);
}
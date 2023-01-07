using AutoMapper;
using Shop.Api.Rest.Responses;
using Shop.Data.Repositories;
using Shop.Models.Domain;
using Shop.Models.DTO;
using Shop.Models.Util;
using Shop.Services.Errors;

namespace Shop.Services;

public class ProductService : IProductService
{
    private readonly IMapper _mapper;
    private readonly ProductRepository _productRepository;
    private readonly RatingRepository _ratingRepository;

    public ProductService(
        IMapper mapper,
        ProductRepository productRepository,
        RatingRepository ratingRepository)
    {
        _mapper = mapper;
        _productRepository = productRepository;
        _ratingRepository = ratingRepository;
    }

    public IEnumerable<ProductDto> GetDtoProducts()
    {
        return _productRepository.GetDbSet().Select(product => _mapper.Map<ProductDto>(product)).ToList();
    }

    public ProductInfoResponse GetInfo(long productId, long customerId)
    {
        var product = _productRepository.FindById(productId);
        if (product == null) throw new ProductNotFoundException(productId);

        var ratings = product.Ratings;
        
        var pairs = ratings
            .GroupBy(rating => rating.Value)
            .Select(r => new RatingCountPair { Rating = r.Key, Count = r.Count() })
            .ToList();
        
        pairs.Sort((a, b) => a.Rating.CompareTo(b.Rating));

        return new ProductInfoResponse
        {
            Description = product.Description,
            AverageRating = (float)Math.Round(ratings.Select(rating => (int)rating.Value).Average(), 1),
            CurrentRating = ratings.Find(rating => rating.CustomerId == customerId)?.Value,
            Ratings = pairs
        };
    }

    public void Evaluation(long productId, long customerId, short rating)
    {
        var optRating = _ratingRepository.FindByProductIdAndCustomerId(productId, customerId);
        if (optRating == null) throw new Exception();

        optRating.Value = rating;
    }
}
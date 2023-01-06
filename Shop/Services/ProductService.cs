using AutoMapper;
using Shop.Data.Repositories;
using Shop.Models.DTO;

namespace Shop.Services;

public class ProductService : IProductService
{
    private readonly IMapper _mapper;
    private readonly ProductRepository _productRepository;

    public ProductService(IMapper mapper, ProductRepository productRepository)
    {
        _mapper = mapper;
        _productRepository = productRepository;
    }

    public IEnumerable<ProductDto> GetDtoProducts()
    {
        return _productRepository.GetDbSet().Select(product => _mapper.Map<ProductDto>(product)).ToList();
    }
}
using Shop.Models.DTO;

namespace Shop.Services;

public interface IProductService
{
    IEnumerable<ProductDto> GetDtoProducts();
}
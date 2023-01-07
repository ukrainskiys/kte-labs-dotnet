using Shop.Api.Rest.Responses;
using Shop.Models.DTO;

namespace Shop.Services;

public interface IProductService
{
    IEnumerable<ProductDto> GetDtoProducts();
    ProductInfoResponse GetInfo(long productId, long customerId);
    void Evaluation(long productId, long customerId, short rating);
}
using System.Diagnostics.CodeAnalysis;
using Shop.Models.DTO;

namespace Shop.Api.Rest.Responses;

[SuppressMessage("ReSharper", "UnusedAutoPropertyAccessor.Global")]
public class ProductListResponse
{
    public IEnumerable<ProductDto> Products { get; init; } = new List<ProductDto>();
}
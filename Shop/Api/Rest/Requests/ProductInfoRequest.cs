using System.Diagnostics.CodeAnalysis;

namespace Shop.Api.Rest.Requests;

[SuppressMessage("ReSharper", "UnusedAutoPropertyAccessor.Global")]
public class ProductInfoRequest
{
    public long CustomerId { get; set; }
    public long ProductId { get; set; }
}
using System.Diagnostics.CodeAnalysis;
using Shop.Domain;

namespace Shop.Api.Rest.Requests;

[SuppressMessage("ReSharper", "UnusedAutoPropertyAccessor.Global")]
public class SaleCalculateRequest
{
    public long ClientId { get; set; }
    public IEnumerable<ProductCountPair> Products { get; init; } = new List<ProductCountPair>();
}
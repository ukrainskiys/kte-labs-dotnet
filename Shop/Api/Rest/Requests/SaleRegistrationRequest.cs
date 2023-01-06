using System.Diagnostics.CodeAnalysis;
using Shop.Models.Util;

namespace Shop.Api.Rest.Requests;

[SuppressMessage("ReSharper", "UnusedAutoPropertyAccessor.Global")]
public class SaleRegistrationRequest
{
    public IEnumerable<ProductCountPair> Products { get; init; } = new List<ProductCountPair>();
    public long SumKopecks { get; set; }
}
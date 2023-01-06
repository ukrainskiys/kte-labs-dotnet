using System.Diagnostics.CodeAnalysis;

namespace Shop.Api.Rest.Responses;

[SuppressMessage("ReSharper", "UnusedAutoPropertyAccessor.Global")]
public class SaleCalculateResponse
{
    public long SumKopecks { get; set; }
}
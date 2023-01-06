using System.Diagnostics.CodeAnalysis;

namespace Shop.Api.Rest.Requests;

[SuppressMessage("ReSharper", "UnusedAutoPropertyAccessor.Global")]
public class SaleInfoRequest
{
    public long CustomerId { get; set; }
    public long ProductId { get; set; }
}
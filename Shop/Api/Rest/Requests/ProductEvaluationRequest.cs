using System.Diagnostics.CodeAnalysis;

namespace Shop.Api.Rest.Requests;

[SuppressMessage("ReSharper", "UnusedAutoPropertyAccessor.Global")]
public class ProductEvaluationRequest
{
    public long CustomerId { get; set; }
    public long ProductId { get; set; }
    public short? Rating { get; set; }
}
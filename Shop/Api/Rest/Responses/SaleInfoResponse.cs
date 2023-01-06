using System.Diagnostics.CodeAnalysis;

namespace Shop.Api.Rest.Responses;

[SuppressMessage("ReSharper", "UnusedAutoPropertyAccessor.Global")]
public class SaleInfoResponse
{
    public int CountChecks { get; set; }
    public decimal AllAmountSpent { get; set; }
    public decimal AllReceivedDiscount { get; set; }
}
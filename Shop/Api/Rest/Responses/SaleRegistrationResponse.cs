using System.Diagnostics.CodeAnalysis;

namespace Shop.Api.Rest.Responses;

[SuppressMessage("ReSharper", "UnusedAutoPropertyAccessor.Global")]
public class SaleRegistrationResponse
{
    public string CheckNumber { get; init; } = string.Empty;
}
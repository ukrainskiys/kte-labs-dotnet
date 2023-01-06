using System.Diagnostics.CodeAnalysis;
using Shop.Domain.Dto;

namespace Shop.Api.Rest.Responses;

[SuppressMessage("ReSharper", "UnusedAutoPropertyAccessor.Global")]
public class CustomerListResponse
{
    public IEnumerable<CustomerDto> Customers { get; init; } = new List<CustomerDto>();
}
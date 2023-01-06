using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Shop.Api.Rest.Requests;

[SuppressMessage("ReSharper", "UnusedAutoPropertyAccessor.Global")]
public class CustomerDiscountsRequest
{
    [Required]
    public long CustomerId { get; set; }
    public short IndividualDiscountFirst { get; set; }
    public short IndividualDiscountSecond { get; set; }
}
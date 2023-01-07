using System.Diagnostics.CodeAnalysis;
using Shop.Models.Util;

namespace Shop.Api.Rest.Responses;

[SuppressMessage("ReSharper", "UnusedAutoPropertyAccessor.Global")]
public class ProductInfoResponse
{
    public string? Description { get; init; }
    public float? AverageRating { get; set; }
    public short? CurrentRating { get; set; }
    public IEnumerable<RatingCountPair> Ratings { get; init; } = new List<RatingCountPair>();
}
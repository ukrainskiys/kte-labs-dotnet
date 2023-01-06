using System.Diagnostics.CodeAnalysis;
using Shop.Domain;

namespace Shop.Api.Rest.Responses;

[SuppressMessage("ReSharper", "UnusedAutoPropertyAccessor.Global")]
public class ProductInfoResponse
{
    public string Description { get; init; } = string.Empty;
    public float AverageRating { get; set; }
    public IEnumerable<RatingCountPair> Ratings { get; init; } = new List<RatingCountPair>();
    public short CurrentRating { get; set; }
}
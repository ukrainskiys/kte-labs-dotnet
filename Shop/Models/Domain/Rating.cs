using Microsoft.EntityFrameworkCore;

namespace Shop.Models.Domain;

[Index(nameof(CustomerId), nameof(ProductId), IsUnique = true)]
public class Rating
{
    public long Id { get; set; }
    public long CustomerId { get; set; }
    public long ProductId { get; set; }
    public short Value { get; set; }
}
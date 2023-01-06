namespace Shop.Models.Domain;

public class Rating
{
    public long Id { get; set; }
    public long CustomerId { get; set; }
    public long ProductId { get; set; }
    public short Value { get; set; }
}
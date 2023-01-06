using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Domain.Models;

public class Rating
{
    public long Id { get; set; }
    public long CustomerId { get; set; }
    public long ProductId { get; set; }
    public short Value { get; set; }
}
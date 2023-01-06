namespace Shop.Models.DTO;

public class CustomerDto
{
    public long Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public short IndividualDiscountFirst { get; set; }
    public short IndividualDiscountSecond { get; set; }
}
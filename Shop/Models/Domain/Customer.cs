namespace Shop.Models.Domain;

/// <summary>
/// Клиент (идентификатор, имя, индивидуальная скидка 1, индивидуальная скидка 2).
/// </summary>
public class Customer
{
    public long Id { get; set; }
    public string? Name { get; set; }
    public short? IndividualDiscountFirst { get; set; }
    public short? IndividualDiscountSecond { get; set; }
}
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Domain.Models;

/// <summary>
/// Клиент (идентификатор, имя, индивидуальная скидка 1, индивидуальная скидка 2).
/// </summary>
public class Customer
{
    public long Id { get; set; }
    public string? Name { get; set; }
    public short? IndividualDiscountFirst { get; set; }
    public short? IndividualDiscountSecond { get; set; }

    public override string ToString()
    {
        return $"{nameof(Id)}: {Id}, {nameof(Name)}: {Name}, {nameof(IndividualDiscountFirst)}: {IndividualDiscountFirst}, {nameof(IndividualDiscountSecond)}: {IndividualDiscountSecond}";
    }
}
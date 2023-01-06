using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Domain.Models;

/// <summary>
/// Позиция - идентификатор товара, кол-во, исходная цена (для заданного кол-ва товаров), конечная цена, конечная скидка (%)
/// </summary>
public class Position
{
    public long Id { get; set; }
    public long SaleFactId { get; set; }
    public long ProductId { get; set; }
    public int Count { get; set; }
    public decimal StartPrice { get; set; }
    public decimal FinalPrice { get; set; }
    public int FinalDiscountPercent { get; set; }
}
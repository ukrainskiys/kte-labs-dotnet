using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Domain.Models;

/// <summary>
/// Факт продажи (идентификатор клиента, дата продажи, номер чека, список позиций)
/// </summary>
public class SaleFact
{
    public long Id { get; set; }
    public DateTime? SaleDateTime { get; set; }
    public string? Check { get; set; }
    public List<Position> Positions = new();
}
namespace Shop.Models.Domain;

/// <summary>
/// Товар (Идентификатор, наименование, Цена, описание, оценки покупателей).
/// </summary>
public class Product
{
    public long Id { get; set; }
    public string? Name { get; set; }
    public decimal Price { get; set; }
    public string? Description { get; set; }
    public List<Rating> Ratings { get; set; } = new();
}
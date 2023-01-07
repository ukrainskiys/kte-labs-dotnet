namespace Shop.Services.Errors;

public class ProductNotFoundException : ArgumentException
{
    public ProductNotFoundException(long productId) : base($"Product not found with id={productId}")
    {
    }
}
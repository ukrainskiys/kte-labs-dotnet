namespace Shop.Services.Errors;

public class CustomerNotFoundException : ArgumentException
{
    public CustomerNotFoundException(long customerId) : base($"Customer not found with id={customerId}")
    {
    }
}
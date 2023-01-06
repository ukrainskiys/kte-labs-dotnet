using Shop.Data.Repositories;
using Shop.Domain.Dto;
using Shop.Domain.Models;

namespace Shop.Services;

public class CustomerService : ICustomerService
{
    private readonly CustomerRepository _customerRepository;

    public CustomerService(CustomerRepository customerRepository)
    {
        _customerRepository = customerRepository;
    }
    
    public IEnumerable<CustomerDto> GetDtoCustomers()
    {
        
            
    }

    public void SetCustomerDiscounts(long customerId, short? discountFirst, short? discountSecond)
    {
        throw new NotImplementedException();
    }
}
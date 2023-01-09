using AutoMapper;
using Shop.Data.Repositories;
using Shop.Models.DTO;
using Shop.Services.Errors;

namespace Shop.Services;

public class CustomerService : ICustomerService
{
    private readonly IMapper _mapper;
    private readonly CustomerRepository _customerRepository;

    public CustomerService(IMapper mapper, CustomerRepository customerRepository)
    {
        _mapper = mapper;
        _customerRepository = customerRepository;
    }
    
    public IEnumerable<CustomerDto> GetDtoCustomers() => _customerRepository.Set
            .Select(customer => _mapper.Map<CustomerDto>(customer))
            .ToList();

    public void SetCustomerDiscounts(long customerId, short? discountFirst, short? discountSecond)
    {
        var customer = _customerRepository.FindById(customerId);
        if (customer == null) throw new CustomerNotFoundException(customerId);

        customer.IndividualDiscountFirst = discountFirst;
        customer.IndividualDiscountSecond = discountSecond;
        
        _customerRepository.Save(customer);
    }
}
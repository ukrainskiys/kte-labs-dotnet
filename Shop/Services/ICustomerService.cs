using Shop.Domain.Dto;
using Shop.Domain.Models;

namespace Shop.Services;

public interface ICustomerService
{
    IEnumerable<CustomerDto> GetDtoCustomers();
    void SetCustomerDiscounts(long customerId, short? discountFirst, short? discountSecond);
}
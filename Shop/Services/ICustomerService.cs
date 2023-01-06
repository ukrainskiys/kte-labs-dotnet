using Shop.Models.DTO;

namespace Shop.Services;

public interface ICustomerService
{
    IEnumerable<CustomerDto> GetDtoCustomers();
    void SetCustomerDiscounts(long customerId, short? discountFirst, short? discountSecond);
}
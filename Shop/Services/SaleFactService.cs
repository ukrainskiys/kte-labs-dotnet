using Shop.Api.Rest.Responses;
using Shop.Models.Util;

namespace Shop.Services;

public class SaleFactService : ISaleFactService
{
    public SaleCalculateResponse Calculate(long customerId, IEnumerable<ProductCountPair> pairs)
    {
        throw new NotImplementedException();
    }
}
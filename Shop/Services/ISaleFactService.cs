using Shop.Api.Rest.Responses;
using Shop.Models.Util;

namespace Shop.Services;

public interface ISaleFactService
{
    SaleCalculateResponse Calculate(long customerId, IEnumerable<ProductCountPair> pairs);
}
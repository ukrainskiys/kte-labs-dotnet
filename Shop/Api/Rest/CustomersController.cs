using Microsoft.AspNetCore.Mvc;
using Shop.Api.Rest.Requests;
using Shop.Api.Rest.Responses;
using Shop.Services;

namespace Shop.Api.Rest;

[ApiController]
[Route("/api/rest/[controller]")]
public class CustomersController : ControllerBase
{
    private readonly CustomerService _customerService;

    public CustomersController(CustomerService customerService)
    {
        _customerService = customerService;
    }

    [HttpGet]
    [Produces("application/json")]
    [ProducesResponseType(typeof(CustomerListResponse), StatusCodes.Status200OK)]
    public IActionResult GetCustomers()
    {
        return Ok(new CustomerListResponse { Customers = _customerService.GetDtoCustomers() });
    }

    [HttpPut("discounts")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public IActionResult SetDiscounts([FromBody] CustomerDiscountsRequest request)
    {
        Console.WriteLine(
            $"id={request.CustomerId}, d1={request.IndividualDiscountFirst}, d2={request.IndividualDiscountSecond}");
        return Ok();
    }
}
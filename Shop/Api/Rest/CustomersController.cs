using Microsoft.AspNetCore.Mvc;
using Shop.Api.Rest.Requests;
using Shop.Api.Rest.Responses;
using Shop.Services;
using Shop.Services.Errors;

namespace Shop.Api.Rest;

[ApiController]
[Route("/api/rest/[controller]")]
public class CustomersController : ControllerBase
{
    private readonly ICustomerService _customerService;

    public CustomersController(ICustomerService customerService)
    {
        _customerService = customerService;
    }

    /// <summary>
    /// Get all clients
    /// </summary>
    /// <response code="200">Success</response>
    [HttpGet]
    [Produces("application/json")]
    [ProducesResponseType(typeof(CustomerListResponse), StatusCodes.Status200OK)]
    public IActionResult GetCustomers()
    {
        return Ok(new CustomerListResponse { Customers = _customerService.GetDtoCustomers() });
    }

    /// <summary>
    /// Change individual discounts for client
    /// </summary>
    /// <response code="200">Success</response>
    /// <response code="404">The customer with the specified ID was not found</response>
    [HttpPut("discounts")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public IActionResult SetDiscounts([FromBody] CustomerDiscountsRequest request)
    {
        try
        {
            _customerService.SetCustomerDiscounts(request.CustomerId, request.IndividualDiscountFirst, request.IndividualDiscountSecond);
            return Ok();
        }
        catch (CustomerNotFoundException e)
        {
            return NotFound(e.Message);
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using Shop.Api.Rest.Requests;
using Shop.Api.Rest.Responses;

namespace Shop.Api.Rest;

[ApiController]
[Route("/api/rest/[controller]")]
public class SaleController : ControllerBase
{
    [HttpPost]
    [Produces("application/json")]
    [ProducesResponseType(typeof(SaleCalculateResponse), StatusCodes.Status201Created)]
    public IActionResult Calculate([FromBody] SaleCalculateRequest request)
    {
        Console.WriteLine($"ci={request.ClientId}");
        foreach (var productCountPair in request.Products)
        {
            Console.WriteLine($"pi={productCountPair.ProductId} c={productCountPair.Count}");
        }

        return Created(nameof(Calculate), new SaleCalculateResponse { SumKopecks = 999999L });
    }

    [HttpPost("registration")]
    [Produces("application/json")]
    [ProducesResponseType(typeof(SaleRegistrationResponse), StatusCodes.Status201Created)]
    public IActionResult Registration([FromBody] SaleRegistrationRequest request)
    {
        Console.WriteLine($"sum={request.SumKopecks}");
        foreach (var productCountPair in request.Products)
        {
            Console.WriteLine($"pi={productCountPair.ProductId} c={productCountPair.Count}");
        }

        return Created(nameof(Registration), new SaleRegistrationResponse { CheckNumber = "00100" });
    }

    [HttpPost("info")]
    [Produces("application/json")]
    [ProducesResponseType(typeof(SaleInfoResponse), StatusCodes.Status200OK)]
    public IActionResult GetInfo([FromBody] SaleInfoRequest request)
    {
        Console.WriteLine($"ci={request.CustomerId} pi={request.ProductId}");
        var r = new SaleInfoResponse()
        {
            AllAmountSpent = 3123123.33m,
            AllReceivedDiscount = 2312m,
            CountChecks = 35
        };
        return Ok(r);
    }
}
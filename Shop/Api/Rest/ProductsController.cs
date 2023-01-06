using Microsoft.AspNetCore.Mvc;
using Shop.Api.Rest.Requests;
using Shop.Api.Rest.Responses;
using Shop.Domain;
using Shop.Domain.Dto;

namespace Shop.Api.Rest;

[ApiController]
[Route("/api/rest/[controller]")]
public class ProductsController : ControllerBase
{
    [HttpGet]
    [Produces("application/json")]
    [ProducesResponseType(typeof(ProductListResponse), StatusCodes.Status200OK)]
    public IActionResult GetCustomers()
    {
        var r = new ProductListResponse
        {
            Products = new List<ProductDto>
            {
                new()
                {
                    Id = 1,
                    Name = "Serega",
                    Price = 99.99m
                }
            }
        };
        return Ok(r);
    }

    [HttpPost("info")]
    [Produces("application/json")]
    [ProducesResponseType(typeof(ProductInfoResponse), StatusCodes.Status200OK)]
    public IActionResult GetInfo([FromBody] ProductInfoRequest request)
    {
        var r = new ProductInfoResponse
        {
            Description = "IPhone",
            AverageRating = 4.7f,
            CurrentRating = 5,
            Ratings = new List<RatingCountPair> { new() { Rating = 5, Count = 2 } }
        };
        return Ok(r);
    }

    [HttpPost("evaluation")]
    [Produces("application/json")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public IActionResult ProductEvaluation([FromBody] ProductEvaluationRequest request)
    {
        Console.WriteLine($"ci={request.CustomerId} pi={request.ProductId} r={request.Rating}");
        return Ok();
    }
}
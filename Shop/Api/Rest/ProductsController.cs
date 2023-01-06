using Microsoft.AspNetCore.Mvc;
using Shop.Api.Rest.Requests;
using Shop.Api.Rest.Responses;
using Shop.Models.DTO;
using Shop.Models.Util;
using Shop.Services;

namespace Shop.Api.Rest;

[ApiController]
[Route("/api/rest/[controller]")]
public class ProductsController : ControllerBase
{
    private readonly IProductService _productService;


    public ProductsController(IProductService productService)
    {
        _productService = productService;
    }

    /// <summary>
    /// Get all products
    /// </summary>
    /// <response code="200">Success</response>
    [HttpGet]
    [Produces("application/json")]
    [ProducesResponseType(typeof(ProductListResponse), StatusCodes.Status200OK)]
    public IActionResult GetProducts()
    {
        return Ok(new ProductListResponse { Products = _productService.GetDtoProducts() });
    }

    /// <summary>
    /// Get full information for product
    /// </summary>
    /// <response code="200">Success</response>
    /// <response code="404">Client or Product with the specified ID was not found</response>
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

    /// <summary>
    /// Create a product valuation
    /// </summary>
    /// <response code="201">Created</response>
    /// <response code="400">Customer don't bought this product</response>
    /// <response code="404">Client or Product with the specified ID was not found</response>
    [HttpPost("evaluation")]
    [Produces("application/json")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public IActionResult ProductEvaluation([FromBody] ProductEvaluationRequest request)
    {
        Console.WriteLine($"ci={request.CustomerId} pi={request.ProductId} r={request.Rating}");
        return Ok();
    }
}
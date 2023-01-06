using AutoMapper;
using Shop.Domain.Dto;
using Shop.Domain.Models;

namespace Shop.Services.Mapper;

public class ShopMappingProfile : Profile
{
    protected ShopMappingProfile()
    {
        CreateMap<CustomerDto, Customer>();
        CreateMap<ProductDto, Product>();
    }
}
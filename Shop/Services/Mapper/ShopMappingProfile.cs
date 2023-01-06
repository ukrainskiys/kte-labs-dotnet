using AutoMapper;
using Shop.Models.Domain;
using Shop.Models.DTO;

namespace Shop.Services.Mapper;

public class ShopMappingProfile : Profile
{
    public ShopMappingProfile()
    {
        CreateMap<Customer, CustomerDto>();
        CreateMap<Product, ProductDto>();
    }
}
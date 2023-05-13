using AutoMapper;
using ProductMarket.Data.Entity;
using ProductMarket.DtoS;

namespace ProductMarket.AutoMapperProfiles;

public class ProductMapper:Profile
{
	public ProductMapper()
	{
		CreateMap<Product,ProductDto>();
	}
}

using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductMarket.Data.DAL;
using ProductMarket.Data.Entity;
using ProductMarket.DtoS;

namespace ProductMarket.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductController : ControllerBase
{
    private readonly ProductDbContext _context;
    private readonly IMapper _mapper;
    public ProductController(ProductDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }
    [HttpGet]
    public ActionResult<List<Product>> Get()
    {
        List<Product> products = _context.Products.ToList();
        return products;
    }
    [HttpGet("{id}")]
    public ActionResult<ProductDto> Get(int id)
    {
        Product product = _context.Products.FirstOrDefault(p=>p.Id == id);
        ProductDto productDto= _mapper.Map<ProductDto>(product);
        return productDto;
    }
    [HttpPost]
    public IActionResult Post([FromBody] ProductPostDto dto)
    {
        Product product = new()
        {
            ProductName=dto.ProductName,
            ProductDescription=dto.ProductDescription,
            Price=dto.Price,
            ImageUrl=dto.ImageUrl,
            Created=dto.Created,
            Enddated=dto.Enddated,
        };
        _context.Products.Add(product);
        _context.SaveChanges();
        return Ok();
    }
}

namespace ProductMarket.DtoS;

public class EditProductDto
{
    public string ProductName { get; set; } = null!;
    public string ProductDescription { get; set; }
    public decimal Price { get; set; }
    public string ImageUrl { get; set; }
}

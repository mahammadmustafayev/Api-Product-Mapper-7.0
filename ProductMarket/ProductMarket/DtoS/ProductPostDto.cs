namespace ProductMarket.DtoS;

public class ProductPostDto
{
    public string ProductName { get; set; } = null!;
    public string ProductDescription { get; set; }
    public decimal Price { get; set; }
    public string ImageUrl { get; set; }
    public string Created { get; set; } = DateTime.Now.ToString("dd/MM/yyyy");
    public string Enddated { get; set; } = DateTime.Now.AddDays(15).AddMonths(2).AddYears(1).ToString("dd/MM/yyyy");
}

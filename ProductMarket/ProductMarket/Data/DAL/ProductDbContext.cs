using Microsoft.EntityFrameworkCore;
using ProductMarket.Data.Configuration;
using ProductMarket.Data.Entity;

namespace ProductMarket.Data.DAL;

public class ProductDbContext : DbContext
{
	public ProductDbContext(DbContextOptions options) : base(options) { }
    public DbSet<Product> Products { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //modelBuilder.ApplyConfiguration(new ProductConfiguration());

        modelBuilder.Entity<Product>().Property(p => p.ProductName).IsRequired().HasMaxLength(250);
        modelBuilder.Entity<Product>().Property(p => p.Created).HasDefaultValue(DateTime.Now.ToString("dd/MM/yyyy"));
        modelBuilder.Entity<Product>().Property(p => p.Price).HasColumnType("decimal(18,2)");
        base.OnModelCreating(modelBuilder);
    }
    
}

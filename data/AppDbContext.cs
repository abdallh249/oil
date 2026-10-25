using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }
    public DbSet<OliveOilProduct> OliveOilProducts { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<OliveOilProduct>().HasData(
            new OliveOilProduct
            {
                Id = 1,
                Name = "Nablus Olive Oil",
                Region = "Nablus",
                PricePerLiter = 66,
                QuantityInStock = 95
            },
            new OliveOilProduct
            {
                Id = 2,
                Name = "Jenin Olive Oil",
                Region = "Jenin",
                PricePerLiter = 45,
                QuantityInStock = 210
            },
            new OliveOilProduct
            {
                Id = 3,
                Name = "Tulkarm Olive Oil",
                Region = "Tulkarm",
                PricePerLiter = 35,
                QuantityInStock = 66
            }
        );
    }
}
using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<Product> Products { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Order> Orders { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>().HasData(
            new Customer { Id = 1, Name = "John Doe", Email = "john@example.com" },
            new Customer { Id = 2, Name = "Jane Doe", Email = "jane@example.com" }
        );

        modelBuilder.Entity<Product>().HasData(
            new Product { Id = 1, Name = "T-Shirt", Price = 19.99m },
            new Product { Id = 2, Name = "Jeans", Price = 49.99m }
        );

        modelBuilder.Entity<Order>().HasData(
            new Order { Id = 1, CustomerId = 1, ProductId = 1, OrderDate = DateTime.Now },
            new Order { Id = 2, CustomerId = 2, ProductId = 2, OrderDate = DateTime.Now }
        );
    }
}

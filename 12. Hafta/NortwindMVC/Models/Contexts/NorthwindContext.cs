using Microsoft.EntityFrameworkCore;
using NortwindMVC.Models.Entities.Category;
using NortwindMVC.Models.Entities.Customer;
using NortwindMVC.Models.Entities.Order;
using NortwindMVC.Models.Entities.Product;

namespace NortwindMVC.Models.Contexts;

public class NorthwindContext : DbContext
{
    // Tables
    public DbSet<Order> Orders { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Category> Categories { get; set; }
    
    // IConfiguration
    private readonly IConfiguration _configuration;

    public NorthwindContext(DbContextOptions<NorthwindContext> options) : base(options) { }
}
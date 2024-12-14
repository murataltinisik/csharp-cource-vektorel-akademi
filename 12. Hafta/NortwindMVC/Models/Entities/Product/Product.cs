namespace NortwindMVC.Models.Entities.Product;

public class Product
{
    public int ProductId { get; set; }
    public int CategoryId { get; set; }
    public decimal UnitPrice { get; set; }
    public short UnitsInStock { get; set; }
    public string? ProductName { get; set; }
    
    public Category.Category Category { get; set; }
}
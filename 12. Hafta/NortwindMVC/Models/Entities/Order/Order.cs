namespace NortwindMVC.Models.Entities.Order;

public class Order
{
    public int OrderId { get; set; }
    public string CustomerId { get; set; }
    public decimal Freight { get; set; }
    public DateTime OrderDate { get; set; }
    public Customer.Customer Customer { get; set; }
}
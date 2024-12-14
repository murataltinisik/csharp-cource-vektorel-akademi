namespace NortwindMVC.Models.Entities.Customer;

public class Customer
{
    public string CustomerId { get; set; }
    public string? Address { get; set; }
    public string? CompanyName { get; set; }
    public string? ContactName { get; set; }
}
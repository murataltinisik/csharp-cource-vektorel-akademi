using Microsoft.AspNetCore.Mvc;
using NortwindMVC.Models.Contexts;
using NortwindMVC.Models.DTOs.Customer;
using NortwindMVC.Models.Entities.Customer;

namespace NortwindMVC.Controllers.Customer;

public class CustomerController : Controller, IController<CustomerDto>
{
    public readonly NorthwindContext _context;

    public CustomerController(NorthwindContext context)
    {
        _context = context;
    }
    
    public IActionResult Index()
    {
        CustomerViewModel customerViewModel = new()
        {
            Customers = _context.Customers
                .OrderByDescending(x => x.CustomerId)
                .ToList()
        };
        
        return View(customerViewModel);
    }

    public IActionResult Add()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Add(CustomerDto t)
    {
        // Valid Values
        if (!ModelState.IsValid)
        {
            // Get first Error
            var error = ModelState.Values
                .SelectMany(x => x.Errors)
                .Select(x => x.ErrorMessage)
                .First();
            
            // Error Message
            TempData["Error"] = error;
            
            return View(t);
        }
        
        // New Customer
        Models.Entities.Customer.Customer customer = new()
        {
            CustomerId = Guid.NewGuid().ToString().Substring(0, 5).ToUpper(),
            Address = t.Address,
            CompanyName = t.CompanyName,
            ContactName = t.ContactName,
        };
         
        // Add to DbSet
        _context.Customers.Add(customer);
        
        // Save Changes
        _context.SaveChanges();
        
        // Success Message
        TempData["Success"] = "Customer Created Successfully.";
        
        return RedirectToAction("Index");
    }
}
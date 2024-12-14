using Microsoft.AspNetCore.Mvc;
using NortwindMVC.Models.Contexts;
using NortwindMVC.Models.Entities.Dashboard;

namespace NortwindMVC.Controllers.Dashboard;

public class DashboardController : Controller
{
    private readonly NorthwindContext _context;

    public DashboardController(NorthwindContext context)
    {
        _context = context;
    }
    
    public IActionResult Index()
    {
        DashboardViewModel viewModel = new()
        {
            NumberOfOrders = _context.Orders.Count(),
            NumberOfProducts = _context.Products.Count(),
            NumberOfCustomer = _context.Customers.Count(),
            NumberOfCategory = _context.Categories.Count(),
        };
        
        return View(viewModel);
    }
}
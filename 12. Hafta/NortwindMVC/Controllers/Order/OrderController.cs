using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NortwindMVC.Models.Contexts;
using NortwindMVC.Models.Entities.Order;

namespace NortwindMVC.Controllers.Order;

public class OrderController : Controller, IController<Models.Entities.Order.Order>
{
    private readonly NorthwindContext _context;
    
    public OrderController(NorthwindContext context)
    {
        _context = context;
    }
    
    public IActionResult Index()
    {
       OrderViewModel orderViewModel = new()
       {
           Orders = _context.Orders.Include("Customer")
               .OrderByDescending(o => o.OrderId)
               .ToList()
       };
       
        return View(orderViewModel);
    }

    public IActionResult Add()
    {
        throw new NotImplementedException();
    }

    public IActionResult Add(Models.Entities.Order.Order t)
    {
        throw new NotImplementedException();
    }
}
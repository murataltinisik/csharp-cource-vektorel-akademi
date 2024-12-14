using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NortwindMVC.Models.Contexts;
using NortwindMVC.Models.DTOs.Product;
using NortwindMVC.Models.Entities.Category;
using NortwindMVC.Models.Entities.Product;

namespace NortwindMVC.Controllers.Product;

public class ProductController : Controller, IController<ProductDto>
{
    private readonly NorthwindContext _context;

    public ProductController(NorthwindContext context)
    {
        _context = context;
    }
    
    public IActionResult Index()
    {
        ProductViewModel productViewModel = new()
        {
            Products = _context.Products
                .Include("Category")
                .OrderByDescending(x => x.ProductId)
                .ToList()
        };
        
        return View(productViewModel);
    }

    public IActionResult Add()
    {
        ViewBag.Categories = _context.Categories.OrderByDescending(x => x.CategoryId).ToList();
        
        return View();
    }

    [HttpPost]
    public IActionResult Add(ProductDto t)
    {
        // Validate Values
        if (!ModelState.IsValid)
        {
            var error = ModelState.Values
                .SelectMany(v => v.Errors)
                .Select(e => e.ErrorMessage)
                .First();
            
            // TempData 
            TempData["Error"] = error;
            
            // Get Categories
            ViewBag.Categories = _context.Categories.OrderByDescending(x => x.CategoryId).ToList();
            
            return View(t);
        }
        
        // New Product
        Models.Entities.Product.Product product = new()
        {
            CategoryId = t.CategoryId,
            ProductName = t.ProductName,
            UnitPrice = t.UnitPrice,
            UnitsInStock = t.UnitsInStock,
        };
        
        // Add to DbSet
        _context.Products.Add(product);
        
        // SaveChanges
        _context.SaveChanges();
        
        return RedirectToAction("Index");
    }
}
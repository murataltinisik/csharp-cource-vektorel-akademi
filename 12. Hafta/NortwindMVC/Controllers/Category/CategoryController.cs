using Microsoft.AspNetCore.Mvc;
using NortwindMVC.Models.Contexts;
using NortwindMVC.Models.DTOs.Category;
using NortwindMVC.Models.Entities.Category;

namespace NortwindMVC.Controllers.Category;

public class CategoryController : Controller, IController<CategoryDto>
{
    private readonly NorthwindContext _context;

    public CategoryController(NorthwindContext context)
    {
        _context = context;
    }
    
    public IActionResult Index()
    {
        CategoryViewModel categoryViewModel = new()
        {
            Categories = _context.Categories
                .OrderByDescending(x => x.CategoryId)
                .ToList()
        };
        
        return View(categoryViewModel);
    }

    public IActionResult Add()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Add(CategoryDto t)
    {
        // Valid Values
        if (!ModelState.IsValid)
        {
            // Get First Error Message
            var error = ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).First();

            // Error Message
            TempData["Error"] = error;
            
            return View(t);
        }
        
        // Add to DbSet
        Models.Entities.Category.Category category = new()
        {
            CategoryName = t.CategoryName,
            Description = t.Description,
        };
        
        _context.Add(category);
        
        // Save Changes
        _context.SaveChanges();
        
        // Success Message
        TempData["Success"] = "Category created";
        
        // Return Index Page
        return RedirectToAction("Index");
    }
}
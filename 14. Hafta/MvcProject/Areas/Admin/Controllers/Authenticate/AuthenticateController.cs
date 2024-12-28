using Microsoft.AspNetCore.Mvc;
using MvcProject.Areas.Admin.Models.Context;
using MvcProject.Areas.Admin.Models.DTOs;
using Newtonsoft.Json;

namespace MvcProject.Areas.Admin.Controllers;

[Area("Admin")]
public class AuthenticateController : Controller
{
    // Database
    private readonly NortwindDatabaseContext _context;

    public AuthenticateController(NortwindDatabaseContext context)
    {
        _context = context;
    }
    
    public IActionResult Login()
    {
        // Is not Null LoggedUser 
        if (HttpContext.Session.GetString("LoggedUser") is not null)
            return RedirectToAction("Index", "Dashboard", new { area = "Admin" });

        return View();
    }
    
    [HttpPost]
    public IActionResult Login(UserDto user)
    {
        // Is Valid
        if (!ModelState.IsValid)
        {
            var error = ModelState.Values
                .SelectMany(v => v.Errors)
                .FirstOrDefault()?.ErrorMessage;

            return Json(new { Message = error, StatusCode = 400 });
        }
        
        // Get User
        var getUser = _context.Users.SingleOrDefault(u => u.Email == user.Email);
        
        // Exists User
        if(getUser is null) return Json(new { Message = "Invalid credentials, User Not Found!", StatusCode = 404 });
        
        // Equals Password (userDto) and Password (DB)
        if(getUser.Password != user.Password) return Json(new { Message = "Invalid credentials, Password not match!", StatusCode = 400 });
        
        // Session
        HttpContext.Session.SetString("LoggedUser", JsonConvert.SerializeObject(getUser));
        
        // Return Success
        return Json(new { Message = "Login Successfully...", StatusCode = 200 });
    }
}
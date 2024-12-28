using Microsoft.AspNetCore.Mvc;
using MvcProject.Areas.Admin.Models.Entities;
using Newtonsoft.Json;

namespace MvcProject.Areas.Admin.Controllers;

[Area("Admin")]
public class DashboardController : BaseController
{
    public IActionResult Index()
    {
        // Get Logged User in Session
        var user = JsonConvert.DeserializeObject<User>(HttpContext.Session.GetString("LoggedUser"));
        
        return View(user);
    }
}
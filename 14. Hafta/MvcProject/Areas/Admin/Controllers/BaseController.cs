using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace MvcProject.Areas.Admin.Controllers;

[Area("Admin")]
public class BaseController : Controller
{
    public override void OnActionExecuting(ActionExecutingContext context)
    {
        // "LoggedUser"
        if (HttpContext.Session.GetString("LoggedUser") is null)
        {
            context.Result = RedirectToAction("Login", "Authenticate", new { area = "Admin" });
        }
        
        base.OnActionExecuting(context);
    }
}
using Microsoft.AspNetCore.Mvc;

namespace NortwindMVC.Controllers;

public interface IController<T> where T : class
{
    public IActionResult Index();
    public IActionResult Add();
    public IActionResult Add(T t);
}
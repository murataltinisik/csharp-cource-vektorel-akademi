using MvcProject.Areas.Admin.Models.Entities;

namespace MvcProject.Areas.Admin.Models.ViewModels;

public class EmployeeViewModel
{
    public int NumberOfEmployee { get; set; } = 0;
    public List<Employee> Employees { get; set; }
}
namespace MvcProject.Areas.Admin.Models.Entities;

public class Employee
{
    public int EmployeeId { get; set; }
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public string City { get; set; }
    public string Country { get; set; }
    public DateTime HireDate { get; set; }
    public DateTime BirthDate { get; set; }
}
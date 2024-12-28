using System.ComponentModel.DataAnnotations;

namespace MvcProject.Areas.Admin.Models.DTOs;

public class EmployeeDto
{
    [Required]
    [MinLength(3, ErrorMessage = "Last Name must be at least 3 characters long.")]
    public string FirstName { get; set; }
    
    [Required]
    [MinLength(3, ErrorMessage = "First Name must be at least 3 characters long.")]
    public string LastName { get; set; }
    
    [Required]
    public string City { get; set; }

    [Required]
    public string Country { get; set; }
    
    [Required]
    public DateTime HireDate { get; set; }
    
    [Required]
    public DateTime BirthDate { get; set; }
}
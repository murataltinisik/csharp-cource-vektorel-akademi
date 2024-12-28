using System.ComponentModel.DataAnnotations;

namespace MvcProject.Areas.Admin.Models.DTOs;

public class UserDto
{
    [Required]
    [MinLength(3, ErrorMessage = "Email must be at least 3 characters long.")]
    public string Email { get; set; }
    
    [Required]
    [MinLength(3, ErrorMessage = "Password must be at least 3 characters long.")]
    public string Password { get; set; }
}
using System.ComponentModel.DataAnnotations;

namespace NortwindMVC.Models.DTOs.Customer;

public class CustomerDto
{
    [Required]
    [StringLength(200, ErrorMessage = "Address cannot exceed 200 characters.")]
    public string? Address { get; set; }

    [Required]
    [StringLength(100, MinimumLength = 2, ErrorMessage = "CompanyName must be between 2 and 100 characters.")]
    public string? CompanyName { get; set; }

    [Required]
    [StringLength(50, ErrorMessage = "ContactName cannot exceed 50 characters.")]
    public string? ContactName { get; set; }
}
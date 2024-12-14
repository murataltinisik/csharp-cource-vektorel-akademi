using System.ComponentModel.DataAnnotations;

namespace NortwindMVC.Models.DTOs.Category;

public class CategoryDto
{
    [Required]
    [StringLength(30)]
    public string? CategoryName { get; set; }
    
    [Required]
    [StringLength(50)]
    public string? Description { get; set; }
}
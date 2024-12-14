using System.ComponentModel.DataAnnotations;

namespace NortwindMVC.Models.DTOs.Product;

public class ProductDto
{
    [Required(ErrorMessage = "CategoryId is required.")]
    [Range(1, int.MaxValue, ErrorMessage = "CategoryId must be greater than 0.")]
    public int CategoryId { get; set; }

    [Required(ErrorMessage = "UnitPrice is required.")]
    [Range(0.01, double.MaxValue, ErrorMessage = "UnitPrice must be greater than 0.")]
    public decimal UnitPrice { get; set; }

    [Required(ErrorMessage = "UnitsInStock is required.")]
    [Range(0, short.MaxValue, ErrorMessage = "UnitsInStock must be a valid non-negative number.")]
    public short UnitsInStock { get; set; }

    [Required(ErrorMessage = "ProductName is required.")]
    [StringLength(100, MinimumLength = 1, ErrorMessage = "ProductName must be between 1 and 100 characters.")]
    public string? ProductName { get; set; }
}
using System.ComponentModel.DataAnnotations;

namespace StorageAPI.DTOs;

public class CreateProductDto
{
    [Required(ErrorMessage = "Name is required.")]
    [StringLength(100, MinimumLength = 2)]
    public string Name { get; set; } = string.Empty;

    [Range(0, 1_000_000, ErrorMessage = "Price must be between 0 and 1,000,000.")]
    public int Price { get; set; }

    [Required]
    [StringLength(50)]
    public string Category { get; set; } = string.Empty;

    [Required]
    [StringLength(20)]
    public string Shelf { get; set; } = string.Empty;

    [Range(0, 100_000, ErrorMessage = "Count must be between 0 and 100,000.")]
    public int Count { get; set; }

    [StringLength(500)]
    public string Description { get; set; } = string.Empty;
}

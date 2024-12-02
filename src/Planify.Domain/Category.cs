using System.ComponentModel.DataAnnotations;

namespace Planify.Domain;

public class Category
{
    public Guid Id { get; set; }

    [Required]
    [MaxLength(50, ErrorMessage = "O nome da categoria não pode exceder 50 caracteres")]
    public required string Name { get; set; }
}
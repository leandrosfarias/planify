using System.ComponentModel.DataAnnotations;

namespace Planify.Domain;

public class User
{
    public Guid Id { get; set; }

    [Required]
    [StringLength(30, MinimumLength = 3, ErrorMessage = "Username must be between 3 and 30 characters")]
    public required string UserName { get; set; }

    [Required]
    [StringLength(320, MinimumLength = 5, ErrorMessage = "Password must be between 5 and 20 characters")]
    [EmailAddress]
    public required string Email { get; set; }

    [Required] public required string PasswordHash { get; set; }
    public List<Transaction> Transactions { get; set; } = [];
    public List<Category> Categories { get; set; } = [];
}
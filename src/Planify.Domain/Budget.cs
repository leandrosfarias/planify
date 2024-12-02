using System.ComponentModel.DataAnnotations;

namespace Planify.Domain;

public class Budget
{
    [Required] public Guid Id { get; set; }
    [Required] public Guid UserId { get; set; }
    [Required] public Guid CategoryId { get; set; }
    [Required] public decimal AmountLimit { get; set; }
    [Required] public int Month { get; set; }
    public int Year { get; set; }
    [Required] public DateTime CreatedAt { get; set; }
    [Required] public DateTime UpdateAt { get; set; }
}
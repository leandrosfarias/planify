using System.ComponentModel.DataAnnotations;

namespace Planify.Domain;

public class Transaction
{
    public Guid Id { get; set; }
    [StringLength(50, MinimumLength = 3)] public string? Description { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdateAt { get; set; }
    public decimal Amount { get; set; }
    public bool IsDeleted { get; set; }
    public bool IsRecurring { get; set; }
    public RecurrencePeriod RecurrencePeriod { get; set; }
    public required string PaymentMethod { get; set; }
    public Guid CategoryId { get; set; }
    public Guid UserId { get; set; }

    public required User User { get; set; }
    public required Category Category { get; set; }
}

public enum RecurrencePeriod
{
    Monthly = 1,
    Weekly = 2,
}
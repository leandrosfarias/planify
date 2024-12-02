namespace Planify.Domain;

public class Report
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public int Month { get; set; }
    public int Year { get; set; }
    public decimal TotalIncome { get; set; }
    public decimal TotalExpenses { get; set; }
    public DateTime CreatedAt { get; set; }
}
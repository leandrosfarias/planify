using Microsoft.EntityFrameworkCore;
using Planify.Domain;

namespace Planify.Infrastructure.DbContext;

public class PlanifyDbContext(DbContextOptions options) : Microsoft.EntityFrameworkCore.DbContext(options)
{
    DbSet<User> Users { get; set; }
    DbSet<Transaction> Transactions { get; set; }
    DbSet<Category> Categories { get; set; }
    DbSet<Budget> Budgets { get; set; }
    DbSet<Report> Reports { get; set; }
}
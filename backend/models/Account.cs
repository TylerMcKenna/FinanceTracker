using System.Transactions;

namespace FinanceTracker.Models;

public class Account
{
    public int Id { get; set; }
    public string? CurrencyType { get; set; }
    public string? AccountName { get; set; }
    public User User { get; set; } = null!;
    public ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
}
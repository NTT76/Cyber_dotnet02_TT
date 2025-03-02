
public class WalletTransaction
{
    public string Type { get; set; }
    public decimal Amount { get; set; }
    public DateTime Time { get; set; }

    public WalletTransaction(string type, decimal amount, DateTime time)
    {
        Type = type;
        Amount = amount;
        Time = time;
    }
}
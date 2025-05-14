namespace SimpleCRM.Models;

public class Account
{
    public int AccountId { get; set; }
    public string Name { get; set; }
    public string? Address { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}
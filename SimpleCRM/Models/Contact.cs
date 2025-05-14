namespace SimpleCRM.Models;

public class Contact
{
    public int ContactId { get; set; }
    public string FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }
    public string? Phone { get; set; }
    public int? AccountId { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}
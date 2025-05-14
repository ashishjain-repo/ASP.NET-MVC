namespace SimpleCRM.Models;

public class Interaction
{
    public int InteractionId { get; set; }
    public string InteractionType { get; set; }
    public DateTime InteractionDate { get; set; }
    public string? Notes { get; set; }
    public int? ContactId { get; set; }
    public int? AccountId { get; set; }
    public int UserId { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}
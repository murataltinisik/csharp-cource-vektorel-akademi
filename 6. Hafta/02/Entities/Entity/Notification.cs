namespace Entities.Entity;

public class Notification
{
    public int Id { get; set; }
    public User User { get; set; }
    public string Content { get; set; }
    public bool IsRead { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
    public DateTime DeletedAt { get; set; }
}
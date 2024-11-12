namespace Entities.Entity;

public class BlockedUser
{
    public int Id { get; set; }
    public User Blocker { get; set; }
    public User Blocked { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
    public DateTime DeletedAt { get; set; }
}
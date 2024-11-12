namespace Entities.Entity;

public class Friend
{
    public int Id { get; set; }
    public User User { get; set; }
    public User FriendUser { get; set; }
    public bool Status { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
    public DateTime DeletedAt { get; set; }
}
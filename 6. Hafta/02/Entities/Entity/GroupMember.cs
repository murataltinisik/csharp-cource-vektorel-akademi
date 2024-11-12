namespace Entities.Entity;

public class GroupMember
{
    public int Id { get; set; }
    public User User { get; set; }
    public Role Role { get; set; }
    public Group Group { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
    public DateTime DeletedAt { get; set; }
}
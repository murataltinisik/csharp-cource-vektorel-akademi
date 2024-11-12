namespace Entities.Entity;

public class PostComment
{
    public int Id { get; set; }
    public Post Post { get; set; }
    public User User { get; set; }
    public string Content { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
    public DateTime DeletedAt { get; set; }
}
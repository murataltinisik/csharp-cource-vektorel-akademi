namespace Entities.Entity;

public class Post
{
    public int Id { get; set; }
    public User User { get; set; }
    public Category Category { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string ImagePath { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
    public DateTime DeletedAt { get; set; }
}
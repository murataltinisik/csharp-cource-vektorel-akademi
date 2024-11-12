namespace Entities.Entity;

public class Report
{
    public int Id { get; set; }
    public Post Post { get; set; }
    public User Reporter { get; set; }
    public User Reported { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
    public DateTime DeletedAt { get; set; }
}
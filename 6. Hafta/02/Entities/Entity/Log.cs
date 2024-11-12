namespace Entities.Entity;

public class Log
{
    public int Id { get; set; }
    public User User { get; set; }
    public string Action { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
    public DateTime DeletedAt { get; set; }
}
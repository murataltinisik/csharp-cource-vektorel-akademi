namespace Entities.Entity;

public class Profile
{
    public int Id { get; set; }
    public User User { get; set; }
    public string Biography { get; set; }
    public DateTime Birthday { get; set; }
    public string Job { get; set; }
    public Country Country { get; set; }
    public City City { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
    public DateTime DeletedAt { get; set; }
}
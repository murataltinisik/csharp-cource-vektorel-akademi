namespace Entities.Entity;

public class ApiKey
{
    public int Id { get; set; }
    public string Key { get; set; }
    public DateTime ExpiryAt { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
    public DateTime DeletedAt { get; set; }
}
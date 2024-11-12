namespace Entities.Entity;

public class PostHashTag
{
    public int Id { get; set; }
    public Post Post { get; set; }
    public HashTag HashTag { get; set; }
}
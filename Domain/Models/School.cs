namespace Domain.Models;

public class School
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public int LevelCount { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}
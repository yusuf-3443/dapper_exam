using System.Runtime.InteropServices.JavaScript;

namespace Domain.Models;

public class Subject
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public int SchoolId { get; set; }
    public int Stage { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}
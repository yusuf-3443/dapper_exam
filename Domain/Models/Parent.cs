namespace Domain.Models;

public class Parent
{
    public int Id { get; set; }
    public string ParentCode { get; set; }
    public required string FullName { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}
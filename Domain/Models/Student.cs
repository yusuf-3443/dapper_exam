namespace Domain.Models;

public class Student
{
    public int Id { get; set; }
    public string StudentCode { get; set; }
    public required string FullName { get; set; }
    public string Gender { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public int SchoolId { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}
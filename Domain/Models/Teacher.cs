namespace Domain.Models;

public class Teacher
{
    public int Id { get; set; }
    public string TeacherCode { get; set; }
    public required string FullName { get; set; }
    public string Gender { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public int WorkingDays { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}
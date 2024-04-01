using Domain.Models;

namespace Infrastructure.Services.StudentService;

public interface IStudentService
{
    List<Student> GetStudents();
    Student GetStudentById(int id);
    string AddStudent(Student student);
    string UpdateStudent(Student student);
    bool DeleteStudent(int id);
}
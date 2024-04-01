using Domain.Models;

namespace Infrastructure.Services.ClassStudentService;

public interface IClassStudentService
{
    List<ClassStudent> GetClassStudents();
    ClassStudent GetClassStudentById(int id);
    string AddClassStudent(ClassStudent classStudent);
    string UpdateClassStudent(ClassStudent classStudent);
    bool DeleteClassStudent(int id);
}
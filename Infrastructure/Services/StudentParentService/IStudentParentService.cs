using Domain.Models;

namespace Infrastructure.Services.StudentParentService;

public interface IStudentParentService
{
    List<StudentParent> GetStudentParents();
    StudentParent GetStudentParentById(int id);
    string AddStudentParent(StudentParent studentParent);
    string UpdateStudentParent(StudentParent studentParent);
    bool DeleteStudentParent(int id);
}
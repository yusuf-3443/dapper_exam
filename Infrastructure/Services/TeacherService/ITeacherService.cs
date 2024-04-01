using Domain.Models;

namespace Infrastructure.Services.TeacherService;

public interface ITeacherService
{
    List<Teacher> GetTeachers();
    Teacher GetTeacherById(int id);
    string AddTeacher(Teacher teacher);
    string UpdateTeacher(Teacher teacher);
    bool DeleteTeacher(int id);
}
using Domain.Models;

namespace Infrastructure.Services.ClassroomService;

public interface IClassroomService
{
    List<Classroom> GetClassrooms();
    Classroom GetClassroomById(int id);
    string AddClassroom(Classroom classroom);
    string UpdateClassroom(Classroom classroom);
    bool DeleteClassroom(int id);
}
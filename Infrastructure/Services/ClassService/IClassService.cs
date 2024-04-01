using Domain.Models;

namespace Infrastructure.Services.ClassService;

public interface IClassService
{
    List<Class> GetClasses();
    Class GetClassById(int id);
    string AddClass(Class class1);
    string UpdateClass(Class class1);
    bool DeleteClass(int id);
}
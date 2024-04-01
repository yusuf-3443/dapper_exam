using Domain.Models;

namespace Infrastructure.Services.ParentService;

public interface IParentService
{
    List<Parent> GetParents();
    Parent GetParentById(int id);
    string AddParent(Parent parent);
    string UpdateParent(Parent parent);
    bool DeleteParent(int id);
}
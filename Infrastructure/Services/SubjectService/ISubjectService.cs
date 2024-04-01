using Domain.Models;

namespace Infrastructure.Services.SubjectService;

public interface ISubjectService
{
    List<Subject> GetScubjects();
    Subject GetSubjectById(int id);
    string AddSubject(Subject subject);
    string UpdateSubject(Subject subject);
    bool DeleteSubject(int id);
}
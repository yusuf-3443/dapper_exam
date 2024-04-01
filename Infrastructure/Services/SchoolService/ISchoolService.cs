using Domain.Models;

namespace Infrastructure.Services.SchoolService;

public interface ISchoolService
{
    List<School> GetSchools();
    School GetSchoolById(int id);
    string AddSchool(School school);
    string UpdateSchool(School school);
    bool DeleteSchool(int id);
}
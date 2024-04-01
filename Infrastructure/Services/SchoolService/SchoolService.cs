using Dapper;
using Domain.Models;
using Infrastructure.DataContext;

namespace Infrastructure.Services.SchoolService;

public class SchoolService : ISchoolService
{
    private readonly DapperContext _context;
    public SchoolService()
    {
        _context = new DapperContext();
    }
    public List<School> GetSchools()
    {
        var sql = $"Select * from schools";
        var result = _context.Connection().Query<School>(sql);
        return result.ToList();
    }

    public School GetSchoolById(int id)
    {
        var sql = $"Select * from schools where id = {@id}";
        var result = _context.Connection().QueryFirstOrDefault<School>(sql);
        return result;
    }

    public string AddSchool(School school)
    {
        var sql = $"Insert into schools(title,levelcount,createdat,updatedat)" +
                  $" values ('{school.Title}',{school.LevelCount},'{school.CreatedAt}','{school.UpdatedAt}')";
        var result = _context.Connection().Execute(sql);
        if (result > 0) return "School successfully added";
        return "Failed to add school";
    }

    public string UpdateSchool(School school)
    {
        var sql = $"Update schools " +
                  $"set title = '{school.Title}',levelcount = {school.LevelCount},createdat = '{school.CreatedAt}',updatedat = '{school.UpdatedAt}' where id = {@school.Id}";
        var result = _context.Connection().Execute(sql);
        if (result > 0) return "School successfully updated";
        return "Failed to update school";
    }

    public bool DeleteSchool(int id)
    {
        var sql = $"Delete from schools where id = {@id}";
        var result = _context.Connection().Execute(sql);
        if (result > 0) return true;
        return false;
    }
}
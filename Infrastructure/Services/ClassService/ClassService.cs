using Dapper;
using Domain.Models;
using Infrastructure.DataContext;

namespace Infrastructure.Services.ClassService;

public class ClassService : IClassService
{
    private readonly DapperContext _context;
    public ClassService()
    {
        _context = new DapperContext();
    }

    public List<Class> GetClasses()
    {
        var sql = $"Select * from classes";
        var result = _context.Connection().Query<Class>(sql);
        return result.ToList();
    }

    public Class GetClassById(int id)
    {
        var sql = $"Select * from classes where id = {@id}";
        var result = _context.Connection().QueryFirstOrDefault<Class>(sql);
        return result;
    }

    public string AddClass(Class class1)
    {
        var sql = $"Insert into classes(class_name,subjectid,teacherid,classroomid,createdat,updatedat) " +
                  $"values ('{class1.ClassName}',{class1.SubjectId},{class1.TeacherId},{class1.ClassroomId},'{class1.CreatedAt}','{class1.UpdatedAt}')";
        var result = _context.Connection().Execute(sql);
        if (result > 0) return "Class successfully added";
        return "Failed to add class";
    }

    public string UpdateClass(Class class1)
    {
        var sql = $"Update classes " +
                  $"set class_name = '{class1.ClassName}',subjectid = {class1.SubjectId},teacherid = {class1.TeacherId},classroomid = {class1.ClassroomId},createdat = '{class1.CreatedAt}',updatedat = '{class1.UpdatedAt}' where id = {@class1.Id}";
        var result = _context.Connection().Execute(sql);
        if (result > 0) return "Class successfully updated";
        return "Failed to update class";
    }

    public bool DeleteClass(int id)
    {
        var sql = $"Delete from classes where id  = {@id}";
        var result = _context.Connection().Execute(sql);
        if (result > 0) return true;
        return false;
    }
}
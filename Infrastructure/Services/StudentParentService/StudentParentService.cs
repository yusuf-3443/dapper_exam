using Dapper;
using Domain.Models;
using Infrastructure.DataContext;

namespace Infrastructure.Services.StudentParentService;

public class StudentParentService : IStudentParentService
{
    private readonly DapperContext _context;
    public StudentParentService()
    {
        _context = new DapperContext();
    }
    public List<StudentParent> GetStudentParents()
    {
        var sql = $"Select * from students_parents";
        var result = _context.Connection().Query<StudentParent>(sql);
        return result.ToList();
    }

    public StudentParent GetStudentParentById(int id)
    {
        var sql = $"Select * from students_parents where id = {@id}";
        var result = _context.Connection().QueryFirstOrDefault<StudentParent>(sql);
        return result;
    }

    public string AddStudentParent(StudentParent studentParent)
    {
        var sql = $"Insert into students_parents(studentid,parentid) " +
                  $"values ({studentParent.StudentId},{studentParent.ParentId})";
        var result = _context.Connection().Execute(sql);
        if (result > 0) return "StudentParent successfully added";
        return "Failed to add studentParent";
    }

    public string UpdateStudentParent(StudentParent studentParent)
    {
        var sql = $"Update students_parents " +
                  $"set studentid = {studentParent.StudentId},parentid = {studentParent.ParentId} where id = {studentParent.Id}";
        var result = _context.Connection().Execute(sql);
        if (result > 0) return "StudentParent successfully updated";
        return "Failed to update studentparent";
    }

    public bool DeleteStudentParent(int id)
    {
        var sql = $"Delete from students_parents where id = {@id}";
        var result = _context.Connection().Execute(sql);
        if (result > 0) return true;
        return false;
    }
}
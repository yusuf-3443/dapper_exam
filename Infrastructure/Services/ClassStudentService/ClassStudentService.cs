using Dapper;
using Domain.Models;
using Infrastructure.DataContext;

namespace Infrastructure.Services.ClassStudentService;

public class ClassStudentService : IClassStudentService
{
    private readonly DapperContext _context;
    public ClassStudentService()
    {
        _context = new DapperContext();
    }

    public List<ClassStudent> GetClassStudents()
    {
        var sql = $"Select * from classes_students";
        var result = _context.Connection().Query<ClassStudent>(sql);
        return result.ToList();
    }

    public ClassStudent GetClassStudentById(int id)
    {
        var sql = $"Select * from classes_students where id = {@id}";
        var result = _context.Connection().QueryFirstOrDefault<ClassStudent>(sql);
        return result;
    }

    public string AddClassStudent(ClassStudent classStudent)
    {
        var sql = $"Insert into classes_students(classid,studentid) " +
                  $"values ({classStudent.ClassId},{classStudent.StudentId})";
        var result = _context.Connection().Execute(sql);
        if (result > 0) return "ClassStudent successfully added";
        return "Failed to add ClassStudent";
    }

    public string UpdateClassStudent(ClassStudent classStudent)
    {
        var sql = $"Update classes_students " +
                  $"set classid = {classStudent.ClassId},studentid = {classStudent.StudentId} where id = {@classStudent.Id}";
        var result = _context.Connection().Execute(sql);
        if (result > 0) return "ClassStudent successfully updated";
        return "Failed to update ClassStudent";
    }

    public bool DeleteClassStudent(int id)
    {
        var sql = $"Delete from classes_students where id = {@id}";
        var result = _context.Connection().Execute(sql);
        if (result > 0) return true;
        return false;
    }
}
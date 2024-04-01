using Dapper;
using Domain.Models;
using Infrastructure.DataContext;

namespace Infrastructure.Services.ClassroomService;

public class ClassroomService : IClassroomService
{
    private readonly DapperContext _context;
    public ClassroomService()
    {
        _context = new DapperContext();
    }
    public List<Classroom> GetClassrooms()
    {
        var sql = $"Select * from classrooms";
        var result = _context.Connection().Query<Classroom>(sql);
        return result.ToList();
    }

    public Classroom GetClassroomById(int id)
    {
        var sql = $"Select * from classrooms where id = {@id}";
        var result = _context.Connection().QueryFirstOrDefault<Classroom>(sql);
        return result;
    }

    public string AddClassroom(Classroom classroom)
    {
        var sql = $"Insert into classrooms(capacity,description,createdat,updatedat) " +
                  $"values ({classroom.Capacity},'{classroom.Description}','{classroom.CreatedAt}','{classroom.UpdatedAt}')";
        var result = _context.Connection().Execute(sql);
        if (result > 0) return "Classroom successfully added";
        return "Failed to add classroom";
    }

    public string UpdateClassroom(Classroom classroom)
    {
        var sql = $"Update classrooms " +
                  $"set capacity = {classroom.Capacity},description = '{classroom.Description}',createdat = '{classroom.CreatedAt}',updatedat = '{classroom.UpdatedAt}' where id = {@classroom.Id}";
        var result = _context.Connection().Execute(sql);
        if (result > 0) return "Classroom successfully updated";
        return "Failed to update classroom";
    }

    public bool DeleteClassroom(int id)
    {
        var sql = $"Delete from classrooms where id = {@id}";
        var result = _context.Connection().Execute(sql);
        if (result > 0) return true;
        return false;
    }
}
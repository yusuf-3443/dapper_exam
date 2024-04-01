using Dapper;
using Domain.Models;
using Infrastructure.DataContext;

namespace Infrastructure.Services.TeacherService;

public class TeacherService : ITeacherService
{
    private readonly DapperContext _context;
    public TeacherService()
    {
        _context = new DapperContext();
    }
    public List<Teacher> GetTeachers()
    {
        var sql = $"Select * from teachers";
        var result = _context.Connection().Query<Teacher>(sql);
        return result.ToList();
    }

    public Teacher GetTeacherById(int id)
    {
        var sql = $"Select * from teachers where id = {@id}";
        var result = _context.Connection().QueryFirstOrDefault<Teacher>(sql);
        return result;
    }

    public string AddTeacher(Teacher teacher)
    {
        var sql = $"Insert into teachers(teacher_code,fullname,gender,email,phone,working_days,createdat,updatedat)" +
                  $" values ('{teacher.TeacherCode}','{teacher.FullName}','{teacher.Gender}','{teacher.Email}','{teacher.Phone}',{teacher.WorkingDays},'{teacher.CreatedAt}','{teacher.UpdatedAt}')";
        var result = _context.Connection().Execute(sql);
        if (result > 0) return "Teacher successfully added";
        return "Failed to add teacher";
    }

    public string UpdateTeacher(Teacher teacher)
    {
        var sql = $"Update teachers " +
                  $"set teacher_code = '{teacher.TeacherCode}',fullname = '{teacher.FullName}'," +
                  $"gender = '{teacher.Gender}',email = '{teacher.Email}',phone = '{teacher.Phone}'," +
                  $"working_days = {teacher.WorkingDays},createdat = '{teacher.CreatedAt}',updatedat = '{teacher.UpdatedAt}' where id = {@teacher.Id}";
        var result = _context.Connection().Execute(sql);
        if (result > 0) return "Teacher successfully updated";
        return "Failed to update teacher";
    }

    public bool DeleteTeacher(int id)
    {
        var sql = $"Delete from teachers where id = {@id}";
        var result = _context.Connection().Execute(sql);
        if (result > 0) return true;
        return false;
    }
}
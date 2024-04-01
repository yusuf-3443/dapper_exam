using Dapper;
using Domain.Models;
using Infrastructure.DataContext;

namespace Infrastructure.Services.StudentService;

public class StudentService : IStudentService
{
    private readonly DapperContext _context;
    public StudentService()
    {
        _context = new DapperContext();
    }
    public List<Student> GetStudents()
    {
        var sql = $"Select * from students";
        var result = _context.Connection().Query<Student>(sql);
        return result.ToList();
    }

    public Student GetStudentById(int id)
    {
        var sql = $"Select * from students where id = {@id}";
        var result = _context.Connection().QueryFirstOrDefault<Student>(sql);
        return result;
    }

    public string AddStudent(Student student)
    {
        var sql = $"Insert into students(student_code,fullname,gender,email,phone,schoolid,createdat,updatedat)" +
                  $" values('{student.StudentCode}','{student.FullName}','{student.Gender}','{student.Email}','{student.Phone}',{student.SchoolId},'{student.CreatedAt}','{student.UpdatedAt}')";
        var result = _context.Connection().Execute(sql);
        if (result > 0) return "Student successfully added";
        return "Failed to add student";
    }

    public string UpdateStudent(Student student)
    {
        var sql = $"Update students " +
                  $"set student_code = '{student.StudentCode}',fullname = '{student.FullName}'," +
                  $"gender = '{student.Gender}',email = '{student.Email}',phone = '{student.Phone}'," +
                  $"schoolid = {student.SchoolId},createdat = '{student.CreatedAt}',updatedat = '{student.UpdatedAt}' where id = {@student.Id}";
        var result = _context.Connection().Execute(sql);
        if (result > 0) return "Student successfully updated";
        return "Failed to update student";
    }

    public bool DeleteStudent(int id)
    {
        var sql = $"Delete from students where id = {@id}";
        var result = _context.Connection().Execute(sql);
        if (result > 0) return true;
        return false;
    }
}
using Dapper;
using Domain.Models;
using Infrastructure.DataContext;

namespace Infrastructure.Services.SubjectService;

public class SubjectService : ISubjectService
{
    private readonly DapperContext _context;
    public SubjectService()
    {
        _context = new DapperContext();
    }
    public List<Subject> GetScubjects()
    {
        var sql = $"Select * from subjects";
        var result = _context.Connection().Query<Subject>(sql);
        return result.ToList();
    }

    public Subject GetSubjectById(int id)
    {
        var sql = $"Select * from subjects where id = {@id}";
        var result = _context.Connection().QueryFirstOrDefault<Subject>(sql);
        return result;
    }

    public string AddSubject(Subject subject)
    {
        var sql = $"Insert into subjects(title,schoolid,stage,createdat,updatedat) " +
                  $"values ('{subject.Title}',{subject.SchoolId},{subject.Stage},'{subject.CreatedAt}','{subject.UpdatedAt}')";
        var result = _context.Connection().Execute(sql);
        if (result > 0) return "Subject successfully added";
        return "Failed to add subject";
    }

    public string UpdateSubject(Subject subject)
    {
        var sql = $"Update subjects " +
                  $"set title = '{subject.Title}',schoolid = {subject.SchoolId},stage = {subject.Stage},createdat = '{subject.CreatedAt}',updatedat = '{subject.UpdatedAt}' where id = {@subject.Id}";
        var result = _context.Connection().Execute(sql);
        if (result > 0) return "Subject successfully updated";
        return "Failed to update subject";
    }

    public bool DeleteSubject(int id)
    {
        var sql = $"Delete from subjects where id = {@id}";
        var result = _context.Connection().Execute(sql);
        if (result > 0) return true;
        return false;
    }
}
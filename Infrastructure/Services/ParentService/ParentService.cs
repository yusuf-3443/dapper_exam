using Dapper;
using Domain.Models;
using Infrastructure.DataContext;

namespace Infrastructure.Services.ParentService;

public class ParentService : IParentService
{
    private readonly DapperContext _context;
    public ParentService()
    {
        _context = new DapperContext();
    }
    public List<Parent> GetParents()
    {
        var sql = $"Select * from parents";
        var result = _context.Connection().Query<Parent>(sql);
        return result.ToList();
    }

    public Parent GetParentById(int id)
    {
        var sql = $"Select * from parents where id = {@id}";
        var result = _context.Connection().QueryFirstOrDefault<Parent>(sql);
        return result;
    }

    public string AddParent(Parent parent)
    {
        var sql = $"Insert into parents(parent_code,fullname,email,phone,createdat,updatedat)" +
                  $" values('{parent.ParentCode}','{parent.FullName}','{parent.Email}','{parent.Phone}','{parent.CreatedAt}','{parent.UpdatedAt}')";
        var result = _context.Connection().Execute(sql);
        if (result > 0) return "Parent successfully added";
        return "Failed to add parent";
    }

    public string UpdateParent(Parent parent)
    {
        var sql = $"Update parents " +
                  $"set parent_code = '{parent.ParentCode}',fullname = '{parent.FullName}',email = '{parent.Email}',phone = '{parent.Phone}',createdat = '{parent.CreatedAt}',updatedat = '{parent.UpdatedAt}' where id = {@parent.Id}";
        var result = _context.Connection().Execute(sql);
        if (result > 0) return "Parent successfully updated";
        return "Failed to update parent";
    }

    public bool DeleteParent(int id)
    {
        var sql = $"Delete from parents where id = {@id}";
        var result = _context.Connection().Execute(sql);
        if (result > 0) return true;
        return false;
    }
}
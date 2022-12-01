using team3.Data;

namespace team3.Services;

/// <summary>
/// Create by Dylan Shaffer.
/// Holds the code for communication between the application and DB.
/// </summary>
public class DbTaskRepo : ITaskRepo
{
    private readonly ApplicationDbContext _db;

    public DbTaskRepo(ApplicationDbContext db)
    {
        _db = db;
    }

    public ICollection<Tasks> ReadAll()
    {
        return _db.TasksList.ToList();
    }
}

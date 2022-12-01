using team3.Data;

namespace team3.Services;

/// <summary>
/// Create by Dylan Shaffer.
/// Sets up the interface for the code to communicate between
/// the application and DB.
/// </summary>
public interface ITaskRepo
{
    public ICollection<Tasks> ReadAll();
}

using Microsoft.AspNetCore.Mvc;
using team3.Pages;

namespace team3.Services;

/// <summary>
/// Added by Dylan Shaffer
/// Purpose is to handle the logic for the Task list,
/// at time of design it should just take tasks from DB
/// and display them on razor page.
/// </summary>
public class TasksController : Controller
{
    private readonly ITaskRepo _taskRepo;

    public TasksController(ITaskRepo taskRepo)
    {
        _taskRepo = taskRepo;
    }
    
    public IActionResult TaskList()
    {
        return View(_taskRepo.ReadAll());
    }
}

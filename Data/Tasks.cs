using System.ComponentModel.DataAnnotations;

namespace team3.Data;

/// <summary>
/// Added by Dylan Shaffer.
/// Purpose is to create a Task object so that
/// the application can communicate with the DB.
/// </summary>
public class Tasks
{
    [Key]
    public int TaskID { get; set; }
    [Required]
    public string Location { get; set; } = String.Empty;
    [Required]
    public string Question { get; set; } = String.Empty;
    [Required]
    public string Answer { get; set; } = String.Empty;
}

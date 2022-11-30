using System.ComponentModel.DataAnnotations;

namespace team3.Entities;

/// <summary>
/// Isaiah Jayne
/// This class represents one of the rows of the Task table
/// used when reading in a row from the database 
/// </summary>
public class Tasks
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Location { get; set; } = string.Empty;
    [Required]
    public string Question { get; set; } = string.Empty;
    [Required]
    public string Answer { get; set; } = string.Empty;
}

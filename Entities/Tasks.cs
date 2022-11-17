using System.ComponentModel.DataAnnotations;

namespace team3.Entities;

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

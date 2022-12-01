using Microsoft.EntityFrameworkCore;
using team3.Data;

namespace team3.Services;

/// <summary>
/// Created by Dylan Shaffer.
/// Purpose is to "talk" to the database.
/// </summary>
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
        
    }

    public DbSet<Tasks> TasksList => Set<Tasks>();
}

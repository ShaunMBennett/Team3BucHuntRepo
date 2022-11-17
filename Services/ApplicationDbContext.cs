using Microsoft.EntityFrameworkCore;
using team3.Data;

namespace team3.Services;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Tasks> TaskList => Set<Tasks>();
}
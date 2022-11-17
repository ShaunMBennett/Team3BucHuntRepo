using Microsoft.EntityFrameworkCore;
using team3.Entities;

namespace team3.Services;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    DbSet<Tasks> TaskList => Set<Tasks>();
}
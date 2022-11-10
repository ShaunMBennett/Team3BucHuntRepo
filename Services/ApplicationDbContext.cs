using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using team3.Data;

namespace team3.Services;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    DbSet<Tasks> TaskList => Set<Tasks>();
}
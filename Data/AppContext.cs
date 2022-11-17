using Microsoft.EntityFrameworkCore;
namespace team3.Data
{
    public class AppContext : DbContext
    {
        public AppContext() { }
        public AppContext(DbContextOptions<AppContext> options) :
              base(options)
        { }
    }
}

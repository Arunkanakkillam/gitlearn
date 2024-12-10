using git1.Model;
using Microsoft.EntityFrameworkCore;

namespace git1.Context
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }
    }
}

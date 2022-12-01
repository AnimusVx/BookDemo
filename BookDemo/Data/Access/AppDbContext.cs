using Microsoft.EntityFrameworkCore;
using BookDemo.Data.Model;

namespace BookDemo.Data.Access
{
    public class AppDbContext : DbContext
    {
        public DbSet<Book>? Books { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
    }
}

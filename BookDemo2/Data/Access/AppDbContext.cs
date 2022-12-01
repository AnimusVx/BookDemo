using BookDemo2.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace BookDemo2.Data.Access
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Book> Books { get; set; }
    }
}

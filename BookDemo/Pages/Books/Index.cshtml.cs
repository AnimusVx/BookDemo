using BookDemo.Data.Access;
using BookDemo.Data.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookDemo.Pages.Books
{
    public class IndexModel : PageModel
    {
        public IEnumerable<Book> Books { get; set; }

        private AppDbContext _context;

        public IndexModel(AppDbContext db) 
        {
            _context = db;
            Books = _context.Books;
        }
        public void OnGet()
        {
        }
    }
}

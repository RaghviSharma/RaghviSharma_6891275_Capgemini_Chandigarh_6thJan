using Microsoft.EntityFrameworkCore;
using MVCDemoBook_ASP.Models;

namespace MVCDemoBook_ASP.Data
{
    public class BookDbContext:DbContext
    {
        public BookDbContext(DbContextOptions<BookDbContext> options) : base(options) { }
        public DbSet<BookModel> books {  get; set; }
    }
}

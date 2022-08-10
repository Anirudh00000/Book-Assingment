using BooksellingAPi.Model;
using Microsoft.EntityFrameworkCore;

namespace BooksellingAPi
{
    public class BookDbContext:DbContext
    {

        public DbSet<Book> BookDetails { get; set; }

        public BookDbContext()
        {

        }

        public BookDbContext(DbContextOptions<BookDbContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-0GGBKPE\\SQLEXPRESS;Initial Catalog=SellBook;Integrated Security=True");
        }

    }

}


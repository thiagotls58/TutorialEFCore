
using Microsoft.EntityFrameworkCore;
using SampleCodeFirst.Models;

namespace SampleCodeFirst.Data
{
    class BookStoreContext : DbContext
    {
        public BookStoreContext() { }
        public BookStoreContext(DbContextOptions<BookStoreContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=exemplo_EF;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) { }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }

    }
}

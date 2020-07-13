using Microsoft.EntityFrameworkCore;
using SampleCodeFirst.Models;

namespace SampleCodeFirst.Data
{
    class BloggingContext : DbContext
    {
        public BloggingContext() { }

        public BloggingContext(DbContextOptions<BloggingContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=exemplo_EF;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) { }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

    }

    
}

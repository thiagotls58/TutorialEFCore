using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SampleDatabaseFrst
{
    public partial class exemplo_EFContext : DbContext
    {
        public exemplo_EFContext()
        {
        }

        public exemplo_EFContext(DbContextOptions<exemplo_EFContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Estudantes> Estudantes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=exemplo_EF;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Estudantes>(entity =>
            {
                entity.HasKey(e => e.EstudanteId);
            });
        }
    }
}

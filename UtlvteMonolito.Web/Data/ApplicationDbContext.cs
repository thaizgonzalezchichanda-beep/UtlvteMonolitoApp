using Microsoft.EntityFrameworkCore;
using UtlvteMonolito.Web.Models;

namespace UtlvteMonolito.Web.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Estudiante> Estudiantes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Estudiante>()
                .HasIndex(e => e.Cedula)
                .IsUnique();
        }
    }
}
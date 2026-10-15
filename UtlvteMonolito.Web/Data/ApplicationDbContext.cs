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
        public DbSet<Asignatura> Asignaturas { get; set; }
        public DbSet<Matricula> Matriculas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Estudiante>()
                .HasIndex(e => e.Cedula)
                .IsUnique();

            modelBuilder.Entity<Matricula>()
                .HasOne(m => m.Estudiante)
                .WithMany(e => e.Matriculas)
                .HasForeignKey(m => m.EstudianteId);

            modelBuilder.Entity<Matricula>()
                .HasOne(m => m.Asignatura)
                .WithMany(a => a.Matriculas)
                .HasForeignKey(m => m.AsignaturaId);
        }
    }
}
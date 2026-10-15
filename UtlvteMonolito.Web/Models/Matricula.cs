using System.ComponentModel.DataAnnotations;

namespace UtlvteMonolito.Web.Models
{
    public class Matricula
    {
        [Key]
        public int Id { get; set; }

        public int EstudianteId { get; set; }
        public Estudiante? Estudiante { get; set; }

        public int AsignaturaId { get; set; }
        public Asignatura? Asignatura { get; set; }

        public DateTime FechaMatricula { get; set; } = DateTime.Now;
    }
}
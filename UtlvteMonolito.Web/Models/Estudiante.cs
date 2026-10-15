using System.ComponentModel.DataAnnotations;

namespace UtlvteMonolito.Web.Models
{
    public class Estudiante
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "La cédula es obligatoria.")]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "La cédula debe contener exactamente 10 dígitos.")]
        public string Cedula { get; set; } = string.Empty;

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [StringLength(100, ErrorMessage = "El nombre no puede superar los 100 caracteres.")]
        public string Nombres { get; set; } = string.Empty;

        [Required(ErrorMessage = "El apellido es obligatorio.")]
        [StringLength(100, ErrorMessage = "El apellido no puede superar los 100 caracteres.")]
        public string Apellidos { get; set; } = string.Empty;

        [Required(ErrorMessage = "El correo institucional es obligatorio.")]
        [EmailAddress(ErrorMessage = "Ingrese un correo electrónico válido con formato institucional.")]
        public string CorreoInstitucional { get; set; } = string.Empty;

        [Required]
        public string Carrera { get; set; } = "Ingeniería en Tecnologías de la Información";

        public DateTime FechaRegistro { get; set; } = DateTime.Now;

        public bool EstadoActivo { get; set; } = true;

        // Propiedad de navegación para la relación Muchos a Muchos
        public ICollection<Matricula> Matriculas { get; set; } = new List<Matricula>();
    }
}
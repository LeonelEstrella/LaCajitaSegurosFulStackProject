using System.ComponentModel.DataAnnotations;

namespace Application.Dtos.DomainDTO
{
    public class UbicacionDTO
    {
        [Required(ErrorMessage = "Se requiere el ID de provincia.")]
        public int ProvinciaId { get; set; }

        [Required(ErrorMessage = "Se requiere el ID de localidad.")]
        public int LocalidadId { get; set; }

        [Required(ErrorMessage = "Se requiere la calle.")]
        [StringLength(100, ErrorMessage = "La calle debe tener como máximo 100 caracteres.")]
        public string Calle { get; set; }

        [Required(ErrorMessage = "Se requiere la altura.")]
        [Range(1, int.MaxValue, ErrorMessage = "La altura debe ser mayor que cero.")]
        public int Altura { get; set; }
    }
}

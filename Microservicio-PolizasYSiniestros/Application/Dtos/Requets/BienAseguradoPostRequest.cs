using Application.Dtos.DomainDTO;
using System.ComponentModel.DataAnnotations;
namespace Application.Dtos.Requets
{
    public class BienAseguradoPostRequest
    {
        [Required(ErrorMessage = "La patente es obligatoria.")]
        [StringLength(10, ErrorMessage = "La patente no debe superar los 10 digitos")]
        public string Patente { get; set; }

        [Required(ErrorMessage = "El codigo de chasis es obligatorio.")]
        [StringLength(50, ErrorMessage = "El codigo del chacis no debe superar los 50 caracteres.")]
        public string CodChasis { get; set; }

        [Required(ErrorMessage = "El número de motor es obligatorio.")]
        [StringLength(50, ErrorMessage = "El codigo del motor no debe superar los 50 caracteres.")]
        public string CodMotor { get; set; }

        public bool TieneGnc { get; set; }

        public bool UsoParticular { get; set; }

        [Required(ErrorMessage = "El ID de la versión del vehículo es obligatorio.")]
        [Range(1, int.MaxValue, ErrorMessage = "La versionId debe ser mayor que cero.")]
        public int VersionId { get; set; }

        [Required(ErrorMessage = "La ubicación es obligatoria.")]
        public UbicacionDTO Ubicacion { get; set; }
    }
}

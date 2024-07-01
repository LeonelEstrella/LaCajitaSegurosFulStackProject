using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class VersionVehiculo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int VersionId { get; set; }
        public string NombreVersion { get; set; }
        public decimal PrecioBase { get; set; }
        public int ModeloId { get; set; }
        public Modelo Modelo { get; set; }
        // public BienAsegurado BienAsegurado { get; set; }
    }
}

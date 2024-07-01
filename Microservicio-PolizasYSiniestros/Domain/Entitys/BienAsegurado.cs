using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entitys
{
    public class BienAsegurado
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BienAseguradoId { get; set; }
        public string Patente { get; set; }
        public string CodChasis { get; set; }
        public string CodMotor { get; set; }
        public bool TieneGnc { get; set; }
        public bool UsoParticular { get; set; }

        public int UbicacionId { get; set; }
        public Ubicacion Ubicacion { get; set; }

        public int VersionId { get; set; }
        // public VersionVehiculo Version { get; set; }


        public Poliza Poliza { get; set; }
    }
}

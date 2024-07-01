using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entitys
{
    public class Ubicacion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UbicacionId { get; set; }
        public int ProvinciaId { get; set; }
        public int LocalidadId { get; set; }
        public string Calle { get; set; }
        public int Altura { get; set; }

        //Relaciones
        public BienAsegurado BienAsegurado { get; set; }

        public Siniestro Siniestro { get; set; }

        public Tercero Tercero { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entitys
{
    public class Siniestro
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SiniestroId { get; set; }
        public string Observacion { get; set; }

        public DateTime Fecha { get; set; }

        public Boolean TieneTercerosInvolucrados { get; set; } 

        public string Imagenes { get; set; } // Ver si tomamos las url y separamos por como o creamos una tabla que contengan todas las url con imagenes

        //Armos las relaciones
        public int PolizaId { get; set; }
        public Poliza Poliza { get; set; }

        public int UbicacionId { get; set; }
        public Ubicacion Ubicacion { get; set; }

        public ICollection<Tercero> TercerosInvolucrados { get; set; }

        public IList<SiniestroTipoDeSiniestro> SiniestroTipoDeSiniestros { get; set; }




    }
}

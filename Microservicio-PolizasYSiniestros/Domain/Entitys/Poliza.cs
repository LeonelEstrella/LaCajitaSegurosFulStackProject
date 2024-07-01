using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entitys
{
    public class Poliza
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PolizaId { get; set; }
        public int PlanId { get; set; }
        public string UsuarioId { get; set; }
        public int NroDePoliza { get; set; }
        public decimal Prima { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public DateTime FechaInicio { get; set; }

        public int BienAseguradoId { get; set; }
        public BienAsegurado BienAsegurado { get; set; }

        public ICollection<Siniestro> Siniestros { get; set; }
    }
}

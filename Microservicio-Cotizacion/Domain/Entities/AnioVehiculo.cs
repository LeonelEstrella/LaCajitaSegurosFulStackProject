using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class AnioVehiculo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AnioId { get; set; }
        public int AnioVehiculoDesde { get; set; }
        public int AnioVehiculoHasta { get; set; }
        public string Peso { get; set; }
    }
}

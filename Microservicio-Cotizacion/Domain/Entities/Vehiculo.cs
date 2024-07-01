using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Vehiculo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int VehiculoId { get; set; }
        public int AnioVehiculo {  get; set; }
        public int MarcaId { get; set; }
        public int ModeloId { get; set; }
        public int VersionId {  get; set; }
        public VersionVehiculo VersionVehiculo { get; set; }
        public Modelo Modelo { get; set; }
        public Marca Marca { get; set; }
    }
}

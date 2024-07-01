using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Modelo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ModeloId { get; set; }
        public string NombreModelo { get; set; }
        public int MarcaId { get; set; }
        public Marca Marca { get; set; }
        public ICollection<VersionVehiculo> vehiculoVersiones { get; set; }
        // public ICollection<Vehiculo> Vehiculos { get; set; }
    }
}

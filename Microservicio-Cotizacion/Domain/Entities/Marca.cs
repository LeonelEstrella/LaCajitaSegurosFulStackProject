using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Marca
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MarcaId { get; set; }
        public string NombreMarca { get; set; }
        public ICollection<Modelo> Modelos { get; set; }
        public ICollection<Vehiculo> Vehiculos { get; set; }
    }
}

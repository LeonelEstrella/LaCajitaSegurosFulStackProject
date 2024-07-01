using System.ComponentModel.DataAnnotations;

namespace Domain.Entitys
{
    public class Provincia
    {
        [Key]
        public int ProvinciaId { get; set; }
        public string Nombre { get; set; }
    }
}

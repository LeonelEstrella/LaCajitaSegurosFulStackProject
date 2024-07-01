using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class RangoEtario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EdadRangoId { get; set; }
        public int EdadDesde { get; set; }
        public int EdadHasta { get; set; }
        public string Peso {  get; set; }
    }
}

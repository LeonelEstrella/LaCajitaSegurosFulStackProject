using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class GNC
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GNCId { get; set; }
        public Boolean HasGNC { get; set; }
        public string Peso { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entitys
{
    public class TipoDeSiniestro
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TipoDeSiniestroId { get; set; }

        public string Nombre { get; set; }

        //Relacion
        public IList<SiniestroTipoDeSiniestro> SiniestroTipoDeSiniestros { get; set; }


    }
}

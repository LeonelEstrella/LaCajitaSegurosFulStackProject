using Application.Dtos.DomainDTO;

namespace Application.Dtos.Requets
{
    public class SiniestroPostRequest
    {
        public string UsuarioId { get; set; }

        public int NroDePoliza { get; set; }


        public SiniestroDTO Siniestro { get; set; }
    }
}

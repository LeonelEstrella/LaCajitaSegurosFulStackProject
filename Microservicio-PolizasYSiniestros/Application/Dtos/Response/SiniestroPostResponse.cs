using Application.Dtos.DomainDTO;

namespace Application.Dtos.Response
{
    public class SiniestroPostResponse
    {
        public int NumeroDeSiniestro { get; set; }

        public SiniestroDTO Siniestro { get; set; }
    }
}

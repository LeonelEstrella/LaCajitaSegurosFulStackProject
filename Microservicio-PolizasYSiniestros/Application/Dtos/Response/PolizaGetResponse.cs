using Application.Dtos.DomainDTO;
using Application.Dtos.Requets;

namespace Application.Dtos.Response
{
    public class PolizaGetResponse
    {
        public int NumeroDePoliza { get; set; }
        public PlanDTO Plan { get; set; }
        public decimal Prima { get; set; }
        public BienAseguradoPostRequest BienAsegurado { get; set; }
        public List<SiniestroPostResponse> Siniestros { get; set; }
    }
}

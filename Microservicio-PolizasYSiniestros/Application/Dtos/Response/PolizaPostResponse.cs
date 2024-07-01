using Application.Dtos.DomainDTO;
using Application.Dtos.Requets;
using Application.NuevosDtos.DomainDto;

namespace Application.Dtos.Response
{
    public class PolizaPostResponse
    {
        public int NumeroDePoliza { get; set; }
        public decimal Prima { get; set; }

        public PlanDTO Plan { get; set; }

        public BienAseguradoDto BienAsegurado { get; set; }
    }
}

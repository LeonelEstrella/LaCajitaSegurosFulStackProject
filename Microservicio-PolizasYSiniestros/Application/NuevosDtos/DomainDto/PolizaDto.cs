
using Application.Dtos.DomainDTO;

namespace Application.NuevosDtos.DomainDto
{
    public class PolizaDto
    {
        public int NumeroDePoliza { get; set; }

        public PlanDTO Plan { get; set; }

        public decimal Prima { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public DateTime FechaInicio { get; set; }

        public BienAseguradoDto BienAsegurado { get; set; }

        public List<SiniestroDto> Siniestros { get; set; }

    }
}

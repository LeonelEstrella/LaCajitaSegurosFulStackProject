
using Application.Dtos.DomainDTO;

namespace Application.NuevosDtos.DomainDto
{
    public class SiniestroDto
    {
        public int SiniestroId { get; set; }
        public DateTime Fecha { get; set; }
        public string Observacion {get; set;}
        public List<TipoSiniestroDto> TipoDeSiniestros { get; set; }
        public List<ImagenDTO> Imagenes { get; set; }


        public UbicacionDto Ubicacion { get; set; }

        public Boolean TieneTercerosInvolucrados { get; set; }

        //public List<TercerosInvolucradosDto> TercerosInvolucrados { get; set; }

    }
}

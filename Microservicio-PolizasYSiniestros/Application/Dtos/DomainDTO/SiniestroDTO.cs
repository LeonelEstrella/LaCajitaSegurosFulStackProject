
namespace Application.Dtos.DomainDTO
{
    public class SiniestroDTO
    {
        public DateTime Fecha { get; set; }

        public List<TipoSiniestroDTO> TiposDeSiniestros { get; set; }

        public string Observacion { get; set; }

        public UbicacionDTO Ubicacion { get; set; }


        public List<ImagenDTO> Imagenes { get; set; }

        public Boolean TieneTercerosInvolucrados { get; set; }

        //public List<TercerosInvolucradosDTO> TercerosInvolucrados { get; set; }
    }
}

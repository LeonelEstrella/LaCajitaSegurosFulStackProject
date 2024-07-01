using Domain.Entities;

namespace Application.Models
{
    public class ObjetoParametrizado
    {
        public AnioVehiculo anioVehiculo { get; set; }
        public GNC gnc { get; set; }
        public Localidad localidad { get; set; }
        public VersionVehiculo version { get; set; }
        public RangoEtario rangoEtario { get; set; } 
        public Marca marca {  get; set; }
        public Modelo modelo { get; set; }
    }
}

namespace Application.NuevosDtos.DomainDto
{
    public class BienAseguradoDto
    {
        public string Patente { get; set; }
        public string CodChasis { get; set; }
        public string CodMotor { get; set; }
        public bool TieneGnc { get; set; }
        public bool UsoParticular { get; set; }
        public VehiculoVersioDto version { get; set; }

        public UbicacionDto Ubicacion { get; set; }
    }
}

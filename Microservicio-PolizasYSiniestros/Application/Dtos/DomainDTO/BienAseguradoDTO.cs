namespace Application.Dtos.DomainDTO
{
    public class BienAseguradoDTO
    {
        public string Patente { get; set; }
        public int CodChasis { get; set; }
        public int CodMotor { get; set; }
        public bool TieneGnc { get; set; }
        public bool UsoParticular { get; set; }
        public int VersionId { get; set; }

        public UbicacionDTO Ubicacion { get; set; }

    }
}

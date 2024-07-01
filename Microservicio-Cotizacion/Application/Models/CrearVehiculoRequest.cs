namespace Application.Models
{
    public class CrearVehiculoRequest
    {
        public string Localidad { get; set; }
        public int Edad {  get; set; }
        public CrearVehiculoDatosVehiculo Automovil { get; set; }
    }

    public class CrearVehiculoDatosVehiculo
    {
        public int AnioVehiculo { get; set; }
        public int MarcaId { get; set; }
        public int ModeloId { get; set; }
        public int VersionId { get; set; }
        public bool GNC { get; set; }
    }
}

namespace Application.Response
{
    public class PlanesResponse
    {
        public string Nombre { get; set; }
        public decimal Prima { get; set; }
        public List<Cobertura> Coberturas { get; set; }
    }

    public class Cobertura
    {
        public string Descripcion { get; set; }
    }
}

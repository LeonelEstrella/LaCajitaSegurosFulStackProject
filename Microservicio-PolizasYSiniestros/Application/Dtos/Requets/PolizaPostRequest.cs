namespace Application.Dtos.Requets
{
    public class PolizaPostRequest
    {
        public int PlanId { get; set; }
        public string UsuarioId { get; set; }
        public decimal Prima { get; set; }

        public BienAseguradoPostRequest BienAsegurado { get; set; }
    }
}

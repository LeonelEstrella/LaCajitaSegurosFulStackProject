namespace Application.Dtos.DomainDTO
{
    public class PlanDTO
    {
        public string Nombre { get; set; }
        public List<PlanCoberturaDTO> Coberturas { get; set; }
    }
}

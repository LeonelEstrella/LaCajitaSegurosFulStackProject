namespace Domain.Entitys
{
    public class SiniestroTipoDeSiniestro
    {
        public int SiniestroId { get; set; }
        public Siniestro Siniestro { get; set; }

        public int TipoDeSiniestroId { get; set; }
        public TipoDeSiniestro TipoDeSiniestro { get; set; }
    }
}

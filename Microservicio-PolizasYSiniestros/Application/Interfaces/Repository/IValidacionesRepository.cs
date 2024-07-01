namespace Application.Interfaces.Repository
{
    public interface IValidacionesRepository
    {
        public Task<Boolean> TieneBienAseguradoAsync(string usuarioId, string patente);
    }
}

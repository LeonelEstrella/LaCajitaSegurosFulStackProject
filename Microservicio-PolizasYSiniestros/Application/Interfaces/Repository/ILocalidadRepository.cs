using Domain.Entitys;

namespace Application.Interfaces.Repository
{
    public interface ILocalidadRepository
    {
        public Task<Localidad> BuscarLocalidadPorIdAsync(int localidadId);
    }
}

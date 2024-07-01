using Domain.Entities;

namespace Application.Interfaces.LocalidadInterfaces
{
    public interface ILocalidadQuery
    {
        Task<Localidad> ObtenerLocalidadPorNombre(string nombre);

        List<Localidad> ObtenerTodasLasLocalidades();
    }
}

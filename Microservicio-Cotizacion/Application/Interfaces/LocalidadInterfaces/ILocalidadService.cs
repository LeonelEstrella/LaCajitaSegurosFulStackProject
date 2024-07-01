using Domain.Entities;

namespace Application.Interfaces.LocalidadInterfaces
{
    public interface ILocalidadService
    {
        Task<Localidad> ObtenerLocalidad(string nombre);

        List<Localidad> ObtenerListaLocalidades();
    }
}

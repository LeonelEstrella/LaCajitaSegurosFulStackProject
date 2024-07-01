using Application.Interfaces.LocalidadInterfaces;
using Domain.Entities;

namespace Application.UseCase.Localidades
{
    public class LocalidadService : ILocalidadService
    {
        private readonly ILocalidadQuery _query;

        public LocalidadService(ILocalidadQuery query)
        {
            _query = query;
        }

        public List<Localidad> ObtenerListaLocalidades()
        {
            return _query.ObtenerTodasLasLocalidades();
        }

        public async Task<Localidad> ObtenerLocalidad(string nombre)
        {
            return await _query.ObtenerLocalidadPorNombre(nombre);
        }
    }
}

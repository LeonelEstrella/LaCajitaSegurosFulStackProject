using Application.Interfaces.AnioVehiculosInterfaces;
using Domain.Entities;

namespace Application.UseCase.AnioVehiculos
{
    public class AnioVehiculoService : IAnioVehiculoService
    {
        private readonly IAnioVehiculoQuery _query;

        public AnioVehiculoService(IAnioVehiculoQuery query)
        {
            _query = query;
        }

        public async Task<AnioVehiculo> ObtenerValoresAnioVehiculo(int anioVehiculo)
        {
            return await _query.ObtenerVehiculo(anioVehiculo);
        }
    }
}

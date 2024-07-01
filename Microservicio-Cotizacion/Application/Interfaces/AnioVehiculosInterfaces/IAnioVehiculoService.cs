using Domain.Entities;

namespace Application.Interfaces.AnioVehiculosInterfaces
{
    public interface IAnioVehiculoService
    {
        Task<AnioVehiculo> ObtenerValoresAnioVehiculo(int anioVehiculo);
    }
}

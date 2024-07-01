using Domain.Entities;

namespace Application.Interfaces.AnioVehiculosInterfaces
{
    public interface IAnioVehiculoQuery
    {
        Task<AnioVehiculo> ObtenerVehiculo(int anioVehiculo);
    }
}

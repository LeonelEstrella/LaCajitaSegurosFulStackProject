using Domain.Entities;

namespace Application.Interfaces.VehiculoInterfaces
{
    public interface IVehiculosCommand
    {
        Task InsertarVehiculo(Vehiculo vehiculo);
    }
}

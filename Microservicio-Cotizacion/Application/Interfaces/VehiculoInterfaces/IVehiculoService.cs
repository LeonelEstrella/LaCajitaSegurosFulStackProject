using Application.Models;
using Application.Response;

namespace Application.Interfaces.VehiculoInterfaces
{
    public interface IVehiculoService
    {
        public Task<int> CotizarVehiculo(CrearVehiculoRequest request);
        public Task<VehiculoResponse> ObtenerVehiculo(int versionId);
    }
}

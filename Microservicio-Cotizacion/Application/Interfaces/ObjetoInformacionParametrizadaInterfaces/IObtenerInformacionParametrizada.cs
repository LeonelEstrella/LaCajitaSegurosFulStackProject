using Application.Models;
using Application.Response;

namespace Application.Interfaces.ObjetoInformacionParametrizadaInterfaces
{
    public interface IObtenerInformacionParametrizada
    {
        Task<ObjetoParametrizado> ObtenerInformacion(CrearVehiculoRequest request, ObjetoParametrizado objetoParametrizado);
        Task<VehiculoResponse> ObtenerInformacionVehiculo(int versionId);
    }
}

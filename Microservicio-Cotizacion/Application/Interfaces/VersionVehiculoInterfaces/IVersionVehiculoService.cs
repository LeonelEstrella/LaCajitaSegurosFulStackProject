using Application.Response;
using Domain.Entities;

namespace Application.Interfaces.VersionVehiculoInterfaces
{
    public interface IVersionVehiculoService
    {
        Task<VersionVehiculo> ObtenerVersion(int versionId, int modeloId);

        Task<VersionVehiculo> ObtenerVersionPorId(int versionId);

        List<VersionResponse> ObtenerListaVersiones(int modeloId);
    }
}

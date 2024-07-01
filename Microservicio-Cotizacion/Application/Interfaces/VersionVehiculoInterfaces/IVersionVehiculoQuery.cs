using Domain.Entities;

namespace Application.Interfaces.VersionVehiculoInterfaces
{
    public interface IVersionVehiculoQuery
    {
        Task<VersionVehiculo> ObtenerVersion(int versionId, int modeloId);
        Task<VersionVehiculo> ObtenerVersionPorId(int versionId);
        List<VersionVehiculo> ObtenerVersiones(int modeloId);
    }
}

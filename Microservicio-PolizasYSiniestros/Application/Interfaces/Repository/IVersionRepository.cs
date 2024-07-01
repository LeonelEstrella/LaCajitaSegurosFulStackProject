using Domain.Entities;

namespace Application.Interfaces.Repository
{
    public interface IVersionRepository
    {
        public Task<VersionVehiculo> BuscarVersionPorVersionIdAsync(int versionId);
    }
}

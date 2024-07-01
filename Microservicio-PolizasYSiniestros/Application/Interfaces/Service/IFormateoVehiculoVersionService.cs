using Application.NuevosDtos.DomainDto;

namespace Application.Interfaces.Service
{
    public interface IFormateoVehiculoVersionService
    {
        public Task<VehiculoVersioDto> MapearVehiculoVersion(int versionId);
    }
}

using Application.Interfaces.Repository;
using Application.Interfaces.Service;
using Application.NuevosDtos.DomainDto;
using AutoMapper;

namespace Application.UserCase
{
    public class FormateoVehiculoVersionServiceImpl : IFormateoVehiculoVersionService
    {
        public IVersionRepository _versionRepository;
        private IMapper _mapper;

        public FormateoVehiculoVersionServiceImpl(IVersionRepository versionRepository, IMapper mapper)
        {
            _versionRepository = versionRepository;
            _mapper = mapper;
        }

        public async Task<VehiculoVersioDto> MapearVehiculoVersion(int versionId)
        {
            VehiculoVersioDto vehiculoVersioDto = _mapper
                                                     .Map<VehiculoVersioDto>(
                                                        await _versionRepository.
                                                            BuscarVersionPorVersionIdAsync(versionId));

            return vehiculoVersioDto;
        }
    }
}

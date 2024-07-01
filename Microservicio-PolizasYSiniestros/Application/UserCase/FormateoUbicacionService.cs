using Application.ConfigMapper;
using Application.Interfaces.Repository;
using Application.Interfaces.Service;
using Application.NuevosDtos.DomainDto;
using AutoMapper;
using Domain.Entitys;

namespace Application.UserCase
{
    public class FormateoUbicacionService : IFormateoUbicacionService
    {
        public IProviciaRepository _proviciaRepository;
        public ILocalidadRepository _localidadRepository;
        public IVersionRepository _versionRepository;
        private IMapper _mapper;

        public FormateoUbicacionService(IProviciaRepository proviciaRepository,
                                        ILocalidadRepository localidadRepository,
                                        IMapper mapper,
                                        IVersionRepository versionRepository)
        {
            _proviciaRepository = proviciaRepository;
            _localidadRepository = localidadRepository;
            _versionRepository = versionRepository;
            _mapper = mapper;
        }

        public async Task<BienAseguradoDto> MapearUbicacionBienAsegurado(BienAsegurado bienAsegurado)
        {
            BienAseguradoDto bienAseguradoDto = _mapper.Map<BienAseguradoDto>(bienAsegurado);

            // bienAseguradoDto.Ubicacion.Provincia = "";
            bienAseguradoDto.Ubicacion.Localidad = "";

            Provincia provincia = await _proviciaRepository.BuscarProviciaPorIdAsync(bienAsegurado.Ubicacion.ProvinciaId);

            Localidad localidad = (await _localidadRepository.BuscarLocalidadPorIdAsync(bienAsegurado.Ubicacion.LocalidadId));

            bienAseguradoDto.Ubicacion.Provincia = provincia.Nombre;
            bienAseguradoDto.Ubicacion.Localidad = localidad.Nombre;

            return bienAseguradoDto;
        }

        public async Task<List<SiniestroDto>> MapearUbicacionSiniestros(List<Siniestro> siniestros)
        {
            var siniestroDtos = new List<SiniestroDto>();

            foreach (var siniestro in siniestros)
            {

                var siniestroDto = _mapper.Map<SiniestroDto>(siniestro);

                //Mapeo de imagenes
                siniestroDto.Imagenes = ImagenMapper.ImagenStringAImagenDTO(siniestro.Imagenes);

                //Mapeo de TipoDeSiniestro
                siniestroDto.TipoDeSiniestros = TipoDeSiniestroMapper.SiniestroTipoDeSiniestroATipoDeSiniestro1(siniestro.SiniestroTipoDeSiniestros);


                var localidad = await _localidadRepository.BuscarLocalidadPorIdAsync(siniestro.Ubicacion.LocalidadId);
                var provincia = await _proviciaRepository.BuscarProviciaPorIdAsync(siniestro.Ubicacion.ProvinciaId);

                siniestroDto.Ubicacion.Localidad = localidad?.Nombre;
                siniestroDto.Ubicacion.Provincia = provincia?.Nombre;

                /*siniestroDto.TercerosInvolucrados = siniestro.TercerosInvolucrados.Select(async tercero =>
                {
                    var terceroDto = _mapper.Map<TercerosInvolucradosDto>(tercero);

                    var terceroLocalidad = await _localidadRepository.BuscarLocalidadPorIdAsync(tercero.Ubicacion.LocalidadId);
                    var terceroProvincia = await _proviciaRepository.BuscarProviciaPorIdAsync(tercero.Ubicacion.ProvinciaId);

                    terceroDto.Ubicacion.Localidad = terceroLocalidad?.Nombre;
                    terceroDto.Ubicacion.Provincia = terceroProvincia?.Nombre;

                    return terceroDto;
                }).Select(task => task.Result).ToList();*/

                siniestroDtos.Add(siniestroDto);
            }

            return siniestroDtos;
        }
    }
}

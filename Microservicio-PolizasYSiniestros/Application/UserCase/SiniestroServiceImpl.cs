using Application.ConfigMapper;
using Application.Dtos.DomainDTO;
using Application.Dtos.Requets;
using Application.Dtos.Response;
using Application.Exceptions;
using Application.Interfaces.Repository;
using Application.Interfaces.Service;
using AutoMapper;
using Domain.Entitys;
using Microsoft.Extensions.Logging;

namespace Application.UserCase
{
    public class SiniestroServiceImpl : ISiniestroService
    {
        private IGenericRepository _genericRepository;
        private ILogger<PolizaServiceImpl> _logger;
        private IMapper _mapper;
        private IPolizaRepository _polizaRepository;
        private IVersionRepository _versionRepository;

        public SiniestroServiceImpl(IGenericRepository genericRepository,
                                    ILogger<PolizaServiceImpl> logger,
                                    IMapper mapper,
                                    IValidacionesRepository validacionesRepository,
                                    IPolizaRepository polizaRepository,
                                    IVersionRepository versionRepository)
        {
            _genericRepository = genericRepository;
            _logger = logger;
            _mapper = mapper;
            _polizaRepository = polizaRepository;
            _versionRepository = versionRepository;
        }


        public async Task<SiniestroPostResponse> RegistrarSiniestroAsync(SiniestroPostRequest siniestroPostRequest)
        {
            _logger.LogInformation("Inicio - RegistrarSiniestroAsync");

            //VersionVehiculo vehiculo = await _versionRepository.BuscarVersionPorVersionIdAsync(1);
            Poliza poliza = await _polizaRepository.BuscarPolizaPorNroPoliza(siniestroPostRequest.NroDePoliza);

            if (poliza == null)
            {
                throw new CustomBadRequest("No se encontro una poliza asociada al nro de poliza: " + siniestroPostRequest.NroDePoliza);
            }

            //Creo el siniestro y mapeo los datos del request
            Siniestro siniestro = _mapper.Map<Siniestro>(siniestroPostRequest);
            siniestro.PolizaId = poliza.PolizaId;

            //Formateo las imagenes del request a un string separado por comas y se las incorporo al objeto siniestro
            siniestro.Imagenes = ImagenMapper.ImagenDTOaImagenString(siniestroPostRequest.Siniestro.Imagenes);

            //Creo la lista de tipo de siniestro y se las incorpor al siniestro
            siniestro.SiniestroTipoDeSiniestros = TipoDeSiniestroMapper
                                                        .TipoDeSiniestroASiniestroTipoDeSiniestro(
                                                                    siniestroPostRequest.Siniestro.TiposDeSiniestros);

            //siniestro.Fecha = siniestroPostRequest.Siniestro.Fecha;

            Siniestro siniestroGuardado = await _genericRepository.save(siniestro);

            //Armo la respuesta
            SiniestroPostResponse response = _mapper.Map<SiniestroPostResponse>(siniestroGuardado);
            response.Siniestro = _mapper.Map<SiniestroDTO>(siniestroGuardado);

            //Mapeo los tipo de siniestros del siniestro guardado al response
            response.Siniestro.TiposDeSiniestros = TipoDeSiniestroMapper
                                                        .SiniestroTipoDeSiniestroATipoDeSiniestro(
                                                                    siniestroGuardado.SiniestroTipoDeSiniestros);

            //Mapeo las imagenes desde un string a una lista de imagenes
            response.Siniestro.Imagenes = ImagenMapper.ImagenStringAImagenDTO(siniestroGuardado.Imagenes);

            _logger.LogInformation("Fin - RegistrarSiniestroAsync");
            return response;
        }
    }
}

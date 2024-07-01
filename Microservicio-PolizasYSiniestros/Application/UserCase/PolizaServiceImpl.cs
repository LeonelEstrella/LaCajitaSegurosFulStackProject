using Application.Dtos.DomainDTO;
using Application.Dtos.Requets;
using Application.Dtos.Response;
using Application.Exceptions;
using Application.Interfaces.Repository;
using Application.Interfaces.Service;
using Application.NuevosDtos.DomainDto;
using AutoMapper;
using Domain.Entitys;
using Microsoft.Extensions.Logging;

namespace Application.UserCase
{
    public class PolizaServiceImpl : IPolizaService
    {
        private IGenericRepository _genericRepository;
        private IValidacionesRepository _validacionesRepository;
        private IPolizaRepository _polizaRepository;
        private IFormateoUbicacionService _formateoUbicacionService;
        public IFormateoVehiculoVersionService _formateoVehiculoVersionService;
        public IHttpServer _httpService;

        private ILogger<PolizaServiceImpl> _logger;
        private IMapper _mapper;

        public PolizaServiceImpl(IGenericRepository genericRepository,
                                 ILogger<PolizaServiceImpl> logger,
                                 IMapper mapper,
                                 IValidacionesRepository validacionesRepository,
                                 IPolizaRepository polizaRepository,
                                 IFormateoUbicacionService formateoUbicacionService,
                                 IFormateoVehiculoVersionService formateoVehiculoVersionService,
                                 IHttpServer httpServer)
        {
            _genericRepository = genericRepository;
            _validacionesRepository = validacionesRepository;
            _logger = logger;
            _mapper = mapper;
            _polizaRepository = polizaRepository;
            _formateoUbicacionService = formateoUbicacionService;
            _formateoVehiculoVersionService = formateoVehiculoVersionService;
            _httpService = httpServer;
        }

        public async Task<List<PolizaDto>> BuscarPolizasConSiniestrosPorUsuarioId(string usuarioId)
        {
            List<PolizaDto> response = new List<PolizaDto>();

            List<Poliza> polizas = await _polizaRepository.BuscarPolizasConSiniestrosPorUsuarioId(usuarioId);


            foreach (Poliza poliza in polizas)
            {
                // Convertimos la Poliza en un PolizaDto
                var polizaDto = _mapper.Map<PolizaDto>(poliza);

                polizaDto.Plan = await _httpService.GetAsync<PlanDTO>($"https://localhost:7272/api/Planes/BuscarPlan?Id={poliza.PlanId}");

                // Mapear las ubicaciones y versiones de los bienes asegurados
                polizaDto.BienAsegurado = await _formateoUbicacionService.MapearUbicacionBienAsegurado(poliza.BienAsegurado);
                polizaDto.BienAsegurado.version = await _formateoVehiculoVersionService.MapearVehiculoVersion(poliza.BienAsegurado.VersionId);

                // Mapear las ubicaciones de los siniestros
                polizaDto.Siniestros = await _formateoUbicacionService.MapearUbicacionSiniestros(poliza.Siniestros.ToList());

                // Agregar el PolizaDto a la respuesta
                response.Add(polizaDto);
            }

            return response;
        }


        public async Task<PolizaPostResponse> GuardarPolizaAsync(PolizaPostRequest polizaPostRequest)
        {
            _logger.LogInformation("Inicio - GuardarPolizaAsync");
            Random random = new Random();

            _logger.LogInformation("Valido que el usuario no tenga una poliza asociado a el bien, No se permite tener dos polizas para un mismo bien");
            if (await _validacionesRepository.TieneBienAseguradoAsync(polizaPostRequest.UsuarioId,
                                                                     polizaPostRequest.BienAsegurado.Patente))
            {
                throw new CustomBadRequest("El cliente ya poseé una poliza asociado al bien con patente: " + polizaPostRequest.BienAsegurado.Patente);
            }

            _logger.LogInformation("Armo la Poliza y persistir en Base");
            Poliza poliza = _mapper.Map<Poliza>(polizaPostRequest);
            poliza.NroDePoliza = random.Next(0, 999999999);
            poliza.FechaInicio = DateTime.Now;
            //Se esta tomando como fecha de vencimiento 6 meses en adelante
            poliza.FechaVencimiento = poliza.FechaInicio.AddMonths(6);

            Poliza polizaGuardada = await _genericRepository.save(poliza);

            PolizaPostResponse response = _mapper.Map<PolizaPostResponse>(polizaGuardada);

            response.Plan = await _httpService.GetAsync<PlanDTO>($"https://localhost:7272/api/Planes/BuscarPlan?Id={polizaPostRequest.PlanId}");

            response.BienAsegurado = await _formateoUbicacionService.MapearUbicacionBienAsegurado(poliza.BienAsegurado);
            response.BienAsegurado.version = await _formateoVehiculoVersionService.MapearVehiculoVersion(poliza.BienAsegurado.VersionId);


            _logger.LogInformation("Fin - GuardarPolizaAsync");
            return response;
        }
    }
}

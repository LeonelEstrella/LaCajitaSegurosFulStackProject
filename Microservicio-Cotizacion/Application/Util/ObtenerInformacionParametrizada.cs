using Application.Interfaces.AnioVehiculosInterfaces;
using Application.Interfaces.GNCInterfaces;
using Application.Interfaces.LocalidadInterfaces;
using Application.Interfaces.MarcaInterfaces;
using Application.Interfaces.ModeloInterfaces;
using Application.Interfaces.ObjetoInformacionParametrizadaInterfaces;
using Application.Interfaces.RangoEtarioInterfaces;
using Application.Interfaces.VersionVehiculoInterfaces;
using Application.Models;
using Application.Response;

namespace Application.Util
{
    public class ObtenerInformacionParametrizada : IObtenerInformacionParametrizada
    {

        private readonly IAnioVehiculoService _anioVehiculoService;
        private readonly IGNCService _gncService;
        private readonly ILocalidadService _localidadService;
        private readonly IRangoEtarioService _rangoEtarioService;
        private readonly IVersionVehiculoService _versionVehiculoService;
        private readonly IMarcaService _marcaService;
        private readonly IModeloService _modeloService;

        public ObtenerInformacionParametrizada(IAnioVehiculoService anioVehiculoService, IGNCService gncService, 
            ILocalidadService localidadService, IRangoEtarioService rangoEtarioService,
            IVersionVehiculoService versionVehiculoService, IMarcaService marcaService, IModeloService modeloService)
        {
            _marcaService = marcaService;
            _modeloService = modeloService;
            _anioVehiculoService = anioVehiculoService;
            _gncService = gncService;
            _localidadService = localidadService;
            _rangoEtarioService = rangoEtarioService;
            _versionVehiculoService = versionVehiculoService;
        }

        public async Task<ObjetoParametrizado> ObtenerInformacion(CrearVehiculoRequest request, ObjetoParametrizado objetoParametrizado) 
        {
            objetoParametrizado.anioVehiculo = await _anioVehiculoService.ObtenerValoresAnioVehiculo(request.Automovil.AnioVehiculo);
            objetoParametrizado.gnc = await _gncService.ObtenerObjetoGNC(request.Automovil.GNC);
            objetoParametrizado.localidad = await _localidadService.ObtenerLocalidad(request.Localidad);
            objetoParametrizado.rangoEtario = await _rangoEtarioService.ObtenerRangoEtario(request.Edad);
            objetoParametrizado.marca = await _marcaService.ObtenerValoresMarca(request.Automovil.MarcaId);
            objetoParametrizado.modelo = await _modeloService.ObtenerValoresModelos(request.Automovil.ModeloId, request.Automovil.MarcaId);
            objetoParametrizado.version = await _versionVehiculoService.ObtenerVersion(request.Automovil.VersionId, request.Automovil.ModeloId);

            return objetoParametrizado;
        }

        public async Task<VehiculoResponse> ObtenerInformacionVehiculo(int versionId) 
        {
            var informacionVersion = await _versionVehiculoService.ObtenerVersionPorId(versionId);
            var informacionModelo = await _modeloService.ObtenerModelo(informacionVersion.ModeloId);
            var informacionMarca = await _marcaService.ObtenerValoresMarca(informacionModelo.MarcaId);   

            return new VehiculoResponse { 
                marca = informacionMarca.NombreMarca,
                modelo = informacionModelo.NombreModelo,
                version = informacionVersion.NombreVersion
            };
        }
        
    }
}

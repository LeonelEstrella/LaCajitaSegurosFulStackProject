using Application.Dtos.Requets;
using Application.Dtos.Response;
using Application.NuevosDtos.DomainDto;

namespace Application.Interfaces.Service
{
    public interface IPolizaService
    {
        public Task<PolizaPostResponse> GuardarPolizaAsync(PolizaPostRequest polizaPostRequest);
        //public Task<List<PolizaGetResponse>> BuscarPolizasConSiniestrosPorUsuarioId(string usuarioId);

        public Task<List<PolizaDto>> BuscarPolizasConSiniestrosPorUsuarioId(string usuarioId);
    }
}

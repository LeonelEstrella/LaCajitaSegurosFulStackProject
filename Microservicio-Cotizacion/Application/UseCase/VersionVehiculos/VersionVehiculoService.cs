using Application.Interfaces.VersionVehiculoInterfaces;
using Application.Response;
using Application.Util;
using Domain.Entities;

namespace Application.UseCase.VersionVehiculos
{
    public class VersionVehiculoService : IVersionVehiculoService
    {
        private readonly IVersionVehiculoQuery _query;

        public VersionVehiculoService(IVersionVehiculoQuery query)
        {
            _query = query;
        }

        public List<VersionResponse> ObtenerListaVersiones(int modeloId)
        {
            var queryModelo = _query.ObtenerVersiones(modeloId);

            if(queryModelo.Count < 1)
            {
                throw new NotFoundException("No se encontró la versión con el id ingresado.");
            }

            List<VersionResponse> listaVersiones = new List<VersionResponse>();
            foreach (var item in queryModelo) 
            {
                listaVersiones.Add(new VersionResponse
                {
                    id = item.VersionId,
                    nombre = item.NombreVersion
                });
            }
            
            return listaVersiones;
        }

        public async Task<VersionVehiculo> ObtenerVersion(int versionId, int modeloId)
        {
            return await _query.ObtenerVersion(versionId, modeloId);
        }

        public async Task<VersionVehiculo> ObtenerVersionPorId(int versionId)
        {
            return await _query.ObtenerVersionPorId(versionId);
        }
    }
}

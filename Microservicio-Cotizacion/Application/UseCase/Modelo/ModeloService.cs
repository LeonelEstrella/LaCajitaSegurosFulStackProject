using Application.Interfaces.ModeloInterfaces;
using Application.Response;
using Application.Util;

namespace Application.UseCase.Modelo
{
    public class ModeloService : IModeloService
    {
        private readonly IModeloQuery _query;

        public ModeloService(IModeloQuery query)
        {
            _query = query;
        }

        public  async Task<Domain.Entities.Modelo> ObtenerValoresModelos(int modeloId, int marcaId)
        {
            return await _query.ObtenerModelo(modeloId, marcaId);
        }

        public async Task<Domain.Entities.Modelo> ObtenerModelo(int modeloId)
        {
            return await _query.ObtenerModeloPorId(modeloId);
        }

        public List<ModeloResponse> ObtenerListaModelos(int marcaId)
        {
            var queryModelo = _query.ObtenerModelos(marcaId);

            if (queryModelo.Count < 1)
            {
                throw new NotFoundException("No se encontró ningún modelo con el id ingresado.");
            }

            List<ModeloResponse> listaModelo = new List<ModeloResponse>();

            foreach (var item in queryModelo)
            {
                listaModelo.Add(new ModeloResponse 
                {
                    id = item.ModeloId,
                    nombre = item.NombreModelo
                });
            }
            return listaModelo;
        }
    }
}

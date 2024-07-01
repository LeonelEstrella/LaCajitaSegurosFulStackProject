using Application.Interfaces.MarcaInterfaces;
using Application.Response;
using Application.Util;

namespace Application.UseCase.Marca
{
    public class MarcaService : IMarcaService
    {
        private readonly IMarcaQuery _query;

        public MarcaService(IMarcaQuery query)
        {
            _query = query;
        }

        public List<MarcaResponse> ObtenerMarcas()
        {
            var queryMarca = _query.ObtenerListaMarca();

            List<MarcaResponse> listaMarca = new List<MarcaResponse>();

            foreach (var item in queryMarca) 
            {
                listaMarca.Add(new MarcaResponse 
                { 
                    id = item.MarcaId,
                    nombre = item.NombreMarca
                });
            }
            return listaMarca;
        }

        public async Task<Domain.Entities.Marca> ObtenerValoresMarca(int marcaId)
        {
            return await _query.ObtenerMarca(marcaId);
        }
    }
}

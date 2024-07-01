using Application.Response;
using Domain.Entities;

namespace Application.Interfaces.ModeloInterfaces
{
    public interface IModeloService
    {
        Task<Modelo> ObtenerValoresModelos(int modeloId, int marcaId);
        Task<Modelo> ObtenerModelo(int modeloId);
        List<ModeloResponse> ObtenerListaModelos(int marcaId);
    }
}

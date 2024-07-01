using Application.Response;
using Domain.Entities;

namespace Application.Interfaces.ModeloInterfaces
{
    public interface IModeloQuery
    {
        Task<Modelo> ObtenerModelo(int modeloId, int marcaId);
        Task<Modelo> ObtenerModeloPorId(int modeloId);
        List<Modelo> ObtenerModelos(int marcaId);
    }
}

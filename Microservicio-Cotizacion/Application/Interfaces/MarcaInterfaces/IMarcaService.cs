using Application.Response;
using Domain.Entities;

namespace Application.Interfaces.MarcaInterfaces
{
    public interface IMarcaService
    {
        Task<Marca> ObtenerValoresMarca(int marcaId);
        List<MarcaResponse> ObtenerMarcas();
    }
}

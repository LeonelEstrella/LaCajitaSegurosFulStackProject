using Domain.Entities;

namespace Application.Interfaces.MarcaInterfaces
{
    public interface IMarcaQuery
    {
        Task<Marca> ObtenerMarca(int marcaId);
        List<Marca> ObtenerListaMarca();
    }
}

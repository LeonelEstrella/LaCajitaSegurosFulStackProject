using Domain.Entities;

namespace Application.Interfaces.RangoEtarioInterfaces
{
    public interface IRangoEtarioQuery
    {
        Task<RangoEtario> ObtenerListaDeRangoEtario(int edad);
    }
}

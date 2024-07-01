using Domain.Entities;

namespace Application.Interfaces.RangoEtarioInterfaces
{
    public interface IRangoEtarioService
    {
        Task<RangoEtario> ObtenerRangoEtario(int edad);
    }
}

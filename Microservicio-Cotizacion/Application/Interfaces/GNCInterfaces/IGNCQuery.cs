using Domain.Entities;

namespace Application.Interfaces.GNCInterfaces
{
    public interface IGNCQuery
    {
        Task<GNC> ObtenerGNCPorBooleano(bool tieneGnc);
    }
}

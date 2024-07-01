using Domain.Entities;

namespace Application.Interfaces.GNCInterfaces
{
    public interface IGNCService
    {
        Task<GNC> ObtenerObjetoGNC(bool tieneGnc);
    }
}

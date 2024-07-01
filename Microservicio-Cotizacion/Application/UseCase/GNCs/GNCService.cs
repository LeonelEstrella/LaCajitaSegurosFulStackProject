using Application.Interfaces.GNCInterfaces;
using Domain.Entities;

namespace Application.UseCase.GNCs
{
    public class GNCService : IGNCService
    {
        private readonly IGNCQuery _query;

        public GNCService(IGNCQuery query)
        {
            _query = query;
        }

        public async Task<GNC> ObtenerObjetoGNC(bool tieneGnc)
        {
            return await _query.ObtenerGNCPorBooleano(tieneGnc);
        }
    }
}

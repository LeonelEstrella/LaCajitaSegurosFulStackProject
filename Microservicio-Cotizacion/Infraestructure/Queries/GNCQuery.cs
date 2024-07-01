using Application.Interfaces.GNCInterfaces;
using Domain.Entities;
using Infraestructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Queries
{
    public class GNCQuery : IGNCQuery
    {
        private readonly AppDbContext _context;

        public GNCQuery(AppDbContext context)
        {
            _context = context;
        }

        public async Task<GNC> ObtenerGNCPorBooleano(bool tieneGnc)
        {
            return await _context.GNC.FirstOrDefaultAsync(tg => tg.HasGNC == tieneGnc);
        }
    }
}

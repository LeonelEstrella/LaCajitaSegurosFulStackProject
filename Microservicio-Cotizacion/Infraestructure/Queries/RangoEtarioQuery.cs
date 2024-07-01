using Application.Interfaces.RangoEtarioInterfaces;
using Domain.Entities;
using Infraestructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Queries
{
    public class RangoEtarioQuery : IRangoEtarioQuery
    {
        private readonly AppDbContext _context;

        public RangoEtarioQuery(AppDbContext context)
        {
            _context = context;
        }

        public async Task<RangoEtario> ObtenerListaDeRangoEtario(int edad)
        {
            return await _context.RangoEtario.FirstOrDefaultAsync(re => re.EdadDesde <= edad && re.EdadHasta >= edad);
        }
    }
}

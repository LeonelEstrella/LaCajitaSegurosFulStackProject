using Application.Interfaces.MarcaInterfaces;
using Domain.Entities;
using Infraestructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Queries
{
    public class MarcaQuery : IMarcaQuery
    {
        private readonly AppDbContext _context;

        public MarcaQuery(AppDbContext context)
        {
            _context = context;
        }

        public List<Marca> ObtenerListaMarca()
        {
            return _context.Marca.ToList();
        }

        public async Task<Marca> ObtenerMarca(int marcaId)
        {
            return await _context.Marca.FirstOrDefaultAsync(m => m.MarcaId == marcaId);
        }
    }
}

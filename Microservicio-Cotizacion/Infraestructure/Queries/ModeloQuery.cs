using Application.Interfaces.ModeloInterfaces;
using Application.Response;
using Domain.Entities;
using Infraestructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Queries
{
    public class ModeloQuery : IModeloQuery
    {
        private readonly AppDbContext _context;

        public ModeloQuery(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Modelo> ObtenerModelo(int modeloId, int marcaId)
        {
            return await _context.Modelo.FirstOrDefaultAsync(mod => mod.ModeloId == modeloId && mod.MarcaId == marcaId);
        }

        public async Task<Modelo> ObtenerModeloPorId(int modeloId)
        {
            return await _context.Modelo.FirstOrDefaultAsync(mod => mod.ModeloId == modeloId);
        }

        public List<Modelo> ObtenerModelos(int marcaId)
        {
            return _context.Modelo.Where(m => m.MarcaId == marcaId).ToList();
        }
    }
}

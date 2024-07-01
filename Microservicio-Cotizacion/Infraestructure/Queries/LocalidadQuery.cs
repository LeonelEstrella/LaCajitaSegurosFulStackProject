using Application.Interfaces.LocalidadInterfaces;
using Domain.Entities;
using Infraestructure.Persistence;
using Microsoft.EntityFrameworkCore;
namespace Infraestructure.Queries
{
    public class LocalidadQuery : ILocalidadQuery
    {
        private readonly AppDbContext _context;

        public LocalidadQuery(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Localidad> ObtenerLocalidadPorNombre(string nombre)
        {
            return await _context.Localidad.FirstOrDefaultAsync(n => n.Nombre == nombre);
        }

        public List<Localidad> ObtenerTodasLasLocalidades() 
        {
            return _context.Localidad.ToList();
        }
    }
}

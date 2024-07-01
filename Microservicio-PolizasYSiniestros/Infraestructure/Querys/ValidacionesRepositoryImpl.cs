using Application.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Querys
{
    public class ValidacionesRepositoryImpl : IValidacionesRepository
    {
        private readonly ApplicationDbContext _context;

        public ValidacionesRepositoryImpl(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> TieneBienAseguradoAsync(string usuarioId, string patente)
        {
            // Verificar si existe más de una póliza para el usuario con la misma patente
            var tieneBienAsegurado = await _context.Poliza
                .CountAsync(p => p.UsuarioId == usuarioId && p.BienAsegurado.Patente == patente) == 1;

            return tieneBienAsegurado;
        }
    }
}

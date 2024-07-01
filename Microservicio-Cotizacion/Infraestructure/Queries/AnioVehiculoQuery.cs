using Application.Interfaces.AnioVehiculosInterfaces;
using Domain.Entities;
using Infraestructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Queries
{
    public class AnioVehiculoQuery : IAnioVehiculoQuery
    {
        private readonly AppDbContext _context;

        public AnioVehiculoQuery(AppDbContext context)
        {
            _context = context;
        }

        public async Task<AnioVehiculo> ObtenerVehiculo(int anioVehiculo)
        {
            return await _context.AnioVehiculo.FirstOrDefaultAsync(av => av.AnioVehiculoDesde <= anioVehiculo && av.AnioVehiculoHasta >= anioVehiculo);
        }
    }
}

using Application.Interfaces.VersionVehiculoInterfaces;
using Domain.Entities;
using Infraestructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Queries
{
    public class VersionVehiculoQuery : IVersionVehiculoQuery
    {
        private readonly AppDbContext _context;

        public VersionVehiculoQuery(AppDbContext context)
        {
            _context = context;
        }

        public async Task<VersionVehiculo> ObtenerVersion(int versionId, int modeloId)
        {
            return await _context.Version.FirstOrDefaultAsync(vv => vv.VersionId == versionId && vv.ModeloId == modeloId);
        }

        public List<VersionVehiculo> ObtenerVersiones(int modeloId)
        {
            return _context.Version.Where(vv => vv.ModeloId == modeloId).ToList();
        }

        public async Task<VersionVehiculo> ObtenerVersionPorId(int versionId)
        {
            return await _context.Version.FirstOrDefaultAsync(vv => vv.VersionId == versionId);
        }
    }
}

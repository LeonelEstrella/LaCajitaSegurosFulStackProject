using Application.Interfaces.Repository;
using Domain.Entitys;

namespace Infraestructure.Querys
{
    public class LocalidaRepositoryImpl : ILocalidadRepository
    {

        private readonly ApplicationDbContext _context;

        public LocalidaRepositoryImpl(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Localidad> BuscarLocalidadPorIdAsync(int localidadId)
        {

            Localidad localidad = await _context.Localidad.FindAsync(localidadId);

            return localidad;
        }
    }
}

using Application.Interfaces.Repository;
using Domain.Entitys;


namespace Infraestructure.Querys
{
    public class ProvinciaRepositoryImpl : IProviciaRepository
    {
        private readonly ApplicationDbContext _context;

        public ProvinciaRepositoryImpl(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Provincia> BuscarProviciaPorIdAsync(int provinciaId)
        {
            Provincia provincia = await _context.Provincia.FindAsync(provinciaId);

            return provincia;
        }
    }
}

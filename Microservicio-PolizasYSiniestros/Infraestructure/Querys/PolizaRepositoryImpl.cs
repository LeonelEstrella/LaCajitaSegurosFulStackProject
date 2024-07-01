using Application.Interfaces.Repository;
using Domain.Entitys;
using Microsoft.EntityFrameworkCore;


namespace Infraestructure.Querys
{
    public class PolizaRepositoryImpl : IPolizaRepository
    {
        private readonly ApplicationDbContext _context;

        public PolizaRepositoryImpl(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Poliza> BuscarPolizaPorNroPoliza(int nroPoliza)
        {
            Poliza polizaEncontrada = await _context.Poliza.FirstOrDefaultAsync(p => p.NroDePoliza == nroPoliza);

            return polizaEncontrada;
        }

        public async Task<List<Poliza>> BuscarPolizasConSiniestrosPorUsuarioId(string usuarioId)
        {
            List<Poliza> polizasEncontradas = await _context.Poliza
                                                            .Include(p => p.Siniestros)
                                                            .Include(p => p.BienAsegurado).ThenInclude(ba => ba.Ubicacion)
                                                            .Include(p => p.Siniestros).ThenInclude(s => s.TercerosInvolucrados)
                                                            .Include(p => p.Siniestros).ThenInclude(s => s.Ubicacion)
                                                            .Include(p => p.Siniestros).ThenInclude(S => S.SiniestroTipoDeSiniestros)
                                                            .Include(p => p.Siniestros).ThenInclude(S => S.SiniestroTipoDeSiniestros).ThenInclude(sts => sts.TipoDeSiniestro)
                                                            .Include(p => p.Siniestros).ThenInclude(s => s.TercerosInvolucrados).ThenInclude(ti => ti.Ubicacion)
                                                            .Where(p => p.UsuarioId == usuarioId).ToListAsync();
            return polizasEncontradas;
        }
    }
}



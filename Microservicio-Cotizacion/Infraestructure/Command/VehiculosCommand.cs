using Application.Interfaces.VehiculoInterfaces;
using Domain.Entities;
using Infraestructure.Persistence;

namespace Infraestructure.Command
{
    public class VehiculosCommand : IVehiculosCommand
    {
        private readonly AppDbContext _context;

        public VehiculosCommand(AppDbContext context)
        {
            _context = context;
        }

        public async Task InsertarVehiculo(Vehiculo vehiculo) 
        {
            _context.Add(vehiculo);
            await _context.SaveChangesAsync();
        }
    }
}

using Domain.Entitys;

namespace Application.Interfaces.Repository
{
    public interface IProviciaRepository
    {
        public Task<Provincia> BuscarProviciaPorIdAsync(int provinciaId);
    }
}

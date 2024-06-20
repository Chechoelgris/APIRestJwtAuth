using Core.Entities;

namespace Core.Interfaces.IRepositories
{
    public interface ICarreraRepository
    {
        Task<IEnumerable<Carrera>> GetAllAsync();
        Task<Carrera> GetByIdAsync(int id);
        Task<Carrera> AddAsync(Carrera carrera);
        Task<Carrera> UpdateAsync(Carrera carrera);
        Task<bool> DeleteAsync(int id);
    }
}

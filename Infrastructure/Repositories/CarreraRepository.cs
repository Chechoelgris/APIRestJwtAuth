using Core.Entities;
using Core.Interfaces.IRepositories;
using Microsoft.EntityFrameworkCore;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class CarreraRepository : ICarreraRepository
    {
        private readonly ApplicationDbContext _context;

        public CarreraRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Carrera>> GetAllAsync()
        {
            return await _context.Carreras.ToListAsync();
        }

        public async Task<Carrera> GetByIdAsync(int id)
        {
            return await _context.Carreras.FindAsync(id);
        }

        public async Task<Carrera> AddAsync(Carrera carrera)
        {
            _context.Carreras.Add(carrera);
            await _context.SaveChangesAsync();
            return carrera;
        }

        public async Task<Carrera> UpdateAsync(Carrera carrera)
        {
            _context.Carreras.Update(carrera);
            await _context.SaveChangesAsync();
            return carrera;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var carrera = await _context.Carreras.FindAsync(id);
            if (carrera == null)
            {
                return false;
            }

            _context.Carreras.Remove(carrera);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}

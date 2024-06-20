using Core.DTOs.Carreras;

namespace Core.Interfaces.IServices
{
    public interface ICarreraService
    {
        Task<IEnumerable<CarreraDto>> GetAllCarrerasAsync();
        Task<CarreraDto> GetCarreraByIdAsync(int id);
        Task<CarreraDto> CreateCarreraAsync(CreateCarreraDto createCarreraDto);
        Task<CarreraDto> UpdateCarreraAsync(UpdateCarreraDto updateCarreraDto);
        Task<bool> DeleteCarreraAsync(int id);
    }
}

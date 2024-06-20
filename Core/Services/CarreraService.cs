using Core.DTOs.Carreras;
using Core.Entities;
using Core.Interfaces.IRepositories;
using Core.Interfaces.IServices;
using AutoMapper;

namespace Core.Services
{
    public class CarreraService : ICarreraService
    {
        private readonly ICarreraRepository _carreraRepository;
        private readonly IMapper _mapper;

        public CarreraService(ICarreraRepository carreraRepository, IMapper mapper)
        {
            _carreraRepository = carreraRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CarreraDto>> GetAllCarrerasAsync()
        {
            var carreras = await _carreraRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<CarreraDto>>(carreras);
        }

        public async Task<CarreraDto> GetCarreraByIdAsync(int id)
        {
            var carrera = await _carreraRepository.GetByIdAsync(id);
            return _mapper.Map<CarreraDto>(carrera);
        }

        public async Task<CarreraDto> CreateCarreraAsync(CreateCarreraDto createCarreraDto)
        {
            var carrera = _mapper.Map<Carrera>(createCarreraDto);
            var createdCarrera = await _carreraRepository.AddAsync(carrera);
            return _mapper.Map<CarreraDto>(createdCarrera);
        }

        public async Task<CarreraDto> UpdateCarreraAsync(UpdateCarreraDto updateCarreraDto)
        {
            var carrera = _mapper.Map<Carrera>(updateCarreraDto);
            var updatedCarrera = await _carreraRepository.UpdateAsync(carrera);
            return _mapper.Map<CarreraDto>(updatedCarrera);
        }

        public async Task<bool> DeleteCarreraAsync(int id)
        {
            return await _carreraRepository.DeleteAsync(id);
        }
    }
}

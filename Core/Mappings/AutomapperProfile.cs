using AutoMapper;
using Core.DTOs.Carreras;
using Core.Entities;

namespace Core.Mappings
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Carrera, CarreraDto>().ReverseMap();
            CreateMap<Carrera, CreateCarreraDto>().ReverseMap();
            CreateMap<Carrera, UpdateCarreraDto>().ReverseMap();

        }
    }
}

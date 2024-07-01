using Application.NuevosDtos.DomainDto;
using AutoMapper;
using Domain.Entitys;

namespace Application.ConfigNuevoMapper
{
    public class UbicacionDtoMapper : Profile
    {
        public UbicacionDtoMapper()
        {
            CreateMap<Ubicacion, UbicacionDto>()
            .ForMember(dest => dest.Calle, opt => opt.MapFrom(src => src.Calle))
            .ForMember(dest => dest.Altura, opt => opt.MapFrom(src => src.Altura)).ReverseMap();

        }
    }
}

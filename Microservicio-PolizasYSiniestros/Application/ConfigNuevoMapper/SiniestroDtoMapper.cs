using Application.NuevosDtos.DomainDto;
using AutoMapper;
using Domain.Entitys;

namespace Application.ConfigNuevoMapper
{
    public class SiniestroDtoMapper : Profile
    {
        public SiniestroDtoMapper()
        {
            CreateMap<Siniestro, SiniestroDto>()
            .ForMember(dest => dest.SiniestroId, opt => opt.MapFrom(src => src.SiniestroId))
            .ForMember(dest => dest.TieneTercerosInvolucrados, opt => opt.MapFrom(src => src.TieneTercerosInvolucrados))
            .ForMember(dest => dest.Ubicacion, opt => opt.MapFrom(src => src.Ubicacion))
            .ForMember(dest => dest.Imagenes, opt => opt.Ignore())
            .ReverseMap();
        }

    }
}

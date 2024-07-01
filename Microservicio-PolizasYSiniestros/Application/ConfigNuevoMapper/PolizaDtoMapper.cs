using Application.NuevosDtos.DomainDto;
using AutoMapper;
using Domain.Entitys;

namespace Application.ConfigNuevoMapper
{
    public class PolizaDtoMapper : Profile
    {
        public PolizaDtoMapper()
        {
            CreateMap<Poliza, PolizaDto>()
            .ForMember(dest => dest.NumeroDePoliza, opt => opt.MapFrom(src => src.NroDePoliza))
            .ForMember(dest => dest.Prima, opt => opt.MapFrom(src => src.Prima))
            .ForMember(dest => dest.BienAsegurado, opt => opt.MapFrom(src => src.BienAsegurado))
            .ReverseMap();
        }
    }
}

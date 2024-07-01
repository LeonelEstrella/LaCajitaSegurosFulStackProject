using Application.Dtos.DomainDTO;
using Application.Dtos.Requets;
using Application.Dtos.Response;
using AutoMapper;
using Domain.Entitys;

namespace Application.ConfigMapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<UbicacionDTO, Ubicacion>().ReverseMap();

            CreateMap<BienAseguradoPostRequest, BienAsegurado>().ReverseMap();

            CreateMap<PolizaPostRequest, Poliza>()
                .ForMember(dest => dest.BienAsegurado, opt => opt.MapFrom(src => src.BienAsegurado))
                .ReverseMap();

            CreateMap<Poliza, PolizaPostResponse>()
            .ForMember(dest => dest.NumeroDePoliza, opt => opt.MapFrom(src => src.NroDePoliza))
            .ForMember(dest => dest.BienAsegurado, opt => opt.MapFrom(src => src.BienAsegurado));

            CreateMap<Poliza, PolizaGetResponse>()
            .ForMember(dest => dest.NumeroDePoliza, opt => opt.MapFrom(src => src.NroDePoliza))
            .ForMember(dest => dest.BienAsegurado, opt => opt.MapFrom(src => src.BienAsegurado))
            .ForMember(dest => dest.Siniestros, opt => opt.MapFrom(src => src.Siniestros));
        }
    }
}

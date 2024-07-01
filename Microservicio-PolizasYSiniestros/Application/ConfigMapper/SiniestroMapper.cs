using Application.Dtos.DomainDTO;
using Application.Dtos.Requets;
using Application.Dtos.Response;
using AutoMapper;
using Domain.Entitys;


namespace Application.ConfigMapper
{
    public class SiniestroMapperProfile : Profile
    {
        public SiniestroMapperProfile()
        {


            //.ForMember(dest => dest.Imagenes, opt => opt.MapFrom(src => src.Imagenes.Split(',').Select(url => new ImagenDTO { Url = url })))
            //.ForMember(dest => dest.TercerosInvolucrados, opt => opt.MapFrom(src => src.TercerosInvolucrados.Select(t => new TercerosInvolucradosDTO { /* Propiedades de TercerosInvolucradosDTO */ })));
            // .ForMember(dest => dest.Imagenes, opt => opt.MapFrom(src => { src.Imagenes.Split(',').Select(url => new ImagenDTO { UrlImagen = url }); }));

            CreateMap<SiniestroDTO, Siniestro>().ReverseMap()
                .ForMember(dest => dest.Imagenes, opt => opt.Ignore());
            //.ForMember(dest => dest.TercerosInvolucrados, opt => opt.Ignore());



            CreateMap<SiniestroPostRequest, Siniestro>()
                  .ForMember(dest => dest.TieneTercerosInvolucrados, opt => opt.MapFrom(src => src.Siniestro.TieneTercerosInvolucrados))
                  .ForMember(dest => dest.Ubicacion, opt => opt.MapFrom(src => src.Siniestro.Ubicacion))
                  .ForMember(dest => dest.Fecha, opt => opt.MapFrom(src => src.Siniestro.Fecha))
                  .ForMember(dest => dest.Observacion, opt => opt.MapFrom(src => src.Siniestro.Observacion)).ReverseMap();
                   

            CreateMap<Siniestro, SiniestroPostResponse>()
                .ForMember(dest => dest.NumeroDeSiniestro, opt => opt.MapFrom(src => src.SiniestroId)).ReverseMap();

        }
    }
}

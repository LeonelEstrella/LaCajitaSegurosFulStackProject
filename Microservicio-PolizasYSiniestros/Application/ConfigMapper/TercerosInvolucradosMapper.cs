using Application.Dtos.DomainDTO;
using AutoMapper;
using Domain.Entitys;


namespace Application.ConfigMapper
{
    public class TercerosInvolucradosMapper : Profile
    {
        public TercerosInvolucradosMapper()
        {
            CreateMap<Tercero, TercerosInvolucradosDTO>().ReverseMap();
        }
    }
}

using Application.Dtos.DomainDTO;
using Application.NuevosDtos.DomainDto;
using Domain.Entitys;

namespace Application.ConfigMapper
{
    public class TipoDeSiniestroMapper
    {

        public static List<SiniestroTipoDeSiniestro> TipoDeSiniestroASiniestroTipoDeSiniestro(List<TipoSiniestroDTO> TiposDeSiniestros)
        {
            List<SiniestroTipoDeSiniestro> tipoDeSiniestros = new List<SiniestroTipoDeSiniestro>();
            foreach (TipoSiniestroDTO tipoSiniestroDTO in TiposDeSiniestros)
            {
                SiniestroTipoDeSiniestro siniestroTipoDeSiniestro = new SiniestroTipoDeSiniestro();
                siniestroTipoDeSiniestro.TipoDeSiniestroId = tipoSiniestroDTO.TipoSiniestroId;

                tipoDeSiniestros.Add(siniestroTipoDeSiniestro);
            }

            return tipoDeSiniestros;
        }

        //Esta ahi que volarlo, en la respuesta del crear poliza se utiliza para devolvel la lista de tipoSiniestro con el id del siniestro
        //Refactorizar para que devuelva el nombre del tipo de siniestro. Como se hace en el metodo de abajo.
        public static List<TipoSiniestroDTO> SiniestroTipoDeSiniestroATipoDeSiniestro(IList<SiniestroTipoDeSiniestro> siniestroTipoDeSiniestros)
        {
            List<TipoSiniestroDTO> listTipoDeSiniestrosDtos = new List<TipoSiniestroDTO>();
            foreach (SiniestroTipoDeSiniestro item in siniestroTipoDeSiniestros)
            {
                TipoSiniestroDTO tipoSiniestroDTO = new TipoSiniestroDTO();
                tipoSiniestroDTO.TipoSiniestroId = item.TipoDeSiniestroId;
                listTipoDeSiniestrosDtos.Add(tipoSiniestroDTO);
            }

            return listTipoDeSiniestrosDtos;
        }

        public static List<TipoSiniestroDto> SiniestroTipoDeSiniestroATipoDeSiniestro1(IList<SiniestroTipoDeSiniestro> siniestroTipoDeSiniestros)
        {
            List<TipoSiniestroDto> listTipoDeSiniestrosDtos = new List<TipoSiniestroDto>();
            foreach (SiniestroTipoDeSiniestro item in siniestroTipoDeSiniestros)
            {
                TipoSiniestroDto tipoSiniestroDto = new TipoSiniestroDto();
                tipoSiniestroDto.Nombre = item.TipoDeSiniestro.Nombre;
                listTipoDeSiniestrosDtos.Add(tipoSiniestroDto);
            }

            return listTipoDeSiniestrosDtos;
        }

    }
}

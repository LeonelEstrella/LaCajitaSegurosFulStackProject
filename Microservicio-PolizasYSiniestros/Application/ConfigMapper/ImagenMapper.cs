using Application.Dtos.DomainDTO;
namespace Application.ConfigMapper
{
    public class ImagenMapper
    {
        public static string ImagenDTOaImagenString(List<ImagenDTO> listaDeImagenes)
        {
            List<string> listImagenesString = new List<string>();
            foreach (ImagenDTO imagenDTO in listaDeImagenes)
            {
                listImagenesString.Add(imagenDTO.UrlImagen);
            }
            return string.Join(",", listImagenesString);
        }

        public static List<ImagenDTO> ImagenStringAImagenDTO(string imagenes)
        {
            List<ImagenDTO> listImagenes = new List<ImagenDTO>();
            List<string> listStringImagenes = imagenes.Split(',').ToList();
            foreach (string item in listStringImagenes)
            {
                ImagenDTO imagenDTO = new ImagenDTO();
                imagenDTO.UrlImagen = item;
                listImagenes.Add(imagenDTO);
            }
            return listImagenes;
        }
    }
}

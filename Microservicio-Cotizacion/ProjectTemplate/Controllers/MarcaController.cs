using Application.Interfaces.MarcaInterfaces;
using Microsoft.AspNetCore.Mvc;

namespace Cotizaciones.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarcaController : ControllerBase
    {
        private readonly IMarcaService _marcaService;

        public MarcaController(IMarcaService marcaService)
        {
            _marcaService = marcaService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllMarcas()
        {
            try
            {
                var result = _marcaService.ObtenerMarcas();
                return new JsonResult(result);
            }

            catch (Exception)
            {
                return NotFound(new { message = "No se encontró ningún vehiculo con esa versión." });
            }
        }
    }
}

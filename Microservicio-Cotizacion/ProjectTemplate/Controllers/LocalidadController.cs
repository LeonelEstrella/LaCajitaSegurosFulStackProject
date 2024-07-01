using Application.Interfaces.LocalidadInterfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cotizaciones.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocalidadController : ControllerBase
    {
        private readonly ILocalidadService _localidadService;

        public LocalidadController(ILocalidadService localidadService)
        {
            _localidadService = localidadService;
        }

        [HttpGet]
        public async Task<IActionResult> ObtenerTodasLasLocalidades()
        {
            try
            {
                var result = _localidadService.ObtenerListaLocalidades();
                return new JsonResult(result);
            }

            catch (Exception)
            {
                return NotFound(new { message = "No se encontró ningún vehiculo con esa versión." });
            }
        }
    }
}

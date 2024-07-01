using Application.Interfaces.VehiculoInterfaces;
using Application.Models;
using Application.Util;
using Microsoft.AspNetCore.Mvc;

namespace Cotizaciones.Controllers
{
    [Route("api/[action]")]
    [ApiController]
    public class CotizacionController : ControllerBase
    {
        private readonly IVehiculoService _service;

        public CotizacionController(IVehiculoService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> Vehiculo(CrearVehiculoRequest request)
        {
            try
            {
                var result = await _service.CotizarVehiculo(request);
                return new JsonResult(result);
            }
            catch (BadRequestException ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Vehiculo(int id) 
        {
            try
            {
                var result = await _service.ObtenerVehiculo(id);
                return new JsonResult(result);
            }

            catch (Exception)
            {
                return NotFound(new { message = "No se encontró ningún vehiculo con esa versión." });
            }
        }
    }
}

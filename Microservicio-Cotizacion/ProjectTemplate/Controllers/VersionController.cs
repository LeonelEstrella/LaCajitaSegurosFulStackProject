using Application.Interfaces.VersionVehiculoInterfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cotizaciones.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VersionController : ControllerBase
    {
        private readonly IVersionVehiculoService _versionService;

        public VersionController(IVersionVehiculoService versionService)
        {
            _versionService = versionService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAllVersiones(int id) 
        {
            try
            {
                var result = _versionService.ObtenerListaVersiones(id);
                return new JsonResult(result);
            }

            catch (Exception ex)
            {
                return NotFound(new { message = ex.Message });
            }
        }
    }
}

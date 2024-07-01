using Application.Interfaces.ModeloInterfaces;
using Microsoft.AspNetCore.Mvc;

namespace Cotizaciones.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModeloController : ControllerBase
    {
        private readonly IModeloService _modeloService;

        public ModeloController(IModeloService modeloService)
        {
            _modeloService = modeloService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAllModelos(int id)
        {
            try
            {
                var result = _modeloService.ObtenerListaModelos(id);
                return new JsonResult(result);
            }

            catch (Exception ex)
            {
                return NotFound(new { message = ex.Message});
            }
        }
    }
}

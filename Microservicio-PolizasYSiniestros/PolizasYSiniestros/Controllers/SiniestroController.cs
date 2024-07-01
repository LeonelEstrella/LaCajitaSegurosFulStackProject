using Application.Dtos.ApiError;
using Application.Dtos.Requets;
using Application.Dtos.Response;
using Application.Exceptions;
using Application.Interfaces.Service;
using Microsoft.AspNetCore.Mvc;
using System.Data.Common;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PolizasYSiniestros.Controllers
{
    [Route("api/")]
    [ApiController]
    public class SiniestroController : ControllerBase
    {


        private readonly ISiniestroService _siniestroService;

        public SiniestroController(ISiniestroService polizaService)
        {
            _siniestroService = polizaService;
        }


        [HttpPost]
        [Route("[controller]/registrar")]
        public async Task<ActionResult<SiniestroPostResponse>> PostAsync([FromBody] SiniestroPostRequest request)
        {
            try
            {
                SiniestroPostResponse response = await _siniestroService.RegistrarSiniestroAsync(request);

                return Ok(response);
            }
            catch (DbException ex)
            {
                return StatusCode(500, new ApiError("Ocurrió un error al consultar la base de datos -->  " + ex.Message));
            }
            catch (CustomBadRequest e)
            {
                return Conflict(new ApiError(e.Message)); ;
            }
        }
    }
}

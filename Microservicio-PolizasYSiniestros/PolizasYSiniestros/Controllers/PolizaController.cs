using Application.Dtos.ApiError;
using Application.Dtos.Requets;
using Application.Dtos.Response;
using Application.Exceptions;
using Application.Interfaces.Service;
using Application.NuevosDtos.DomainDto;
using Microsoft.AspNetCore.Mvc;
using System.Data.Common;
using System.Net;

namespace PolizasYSiniestros.Controllers
{
    [Route("api/")]
    [ApiController]
    public class PolizaController : ControllerBase
    {

        private readonly IPolizaService _polizaService;

        public PolizaController(IPolizaService polizaService)
        {
            _polizaService = polizaService;
        }

        [HttpGet]
        [Route("[controller]/buscarPolizasConSiniestros/{usuarioId}")]
        public async Task<ActionResult<List<PolizaDto>>> GetAsync(string usuarioId)
        {
            try
            {
                List<PolizaDto> response = await _polizaService.BuscarPolizasConSiniestrosPorUsuarioId(usuarioId);
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

        /// <summary>
        ///  Crea una nueva poliza..
        /// </summary>
        /// <remarks>
        /// Permite la creación de una nueva poliza en el sistema.
        /// </remarks>
        /// <param name="request">Solicitud de creacion de poliza</param>
        /// <response code="201">Poliza creada con éxito</response>
        /// <response code="409">Conflicto.</response>
        /// <response code="500">Ocurrio una falla en el servidor</response>
        /// <returns>Una Poliza.</returns>
        [HttpPost]
        [Route("[controller]/registrar")]
        public async Task<ActionResult<PolizaPostResponse>> PostAsync([FromBody] PolizaPostRequest request)
        {
            try
            {
                PolizaPostResponse response = await _polizaService.GuardarPolizaAsync(request);

                //return new JsonResult(new Result(response, HttpStatusCode.Created)) { StatusCode = 201 };
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

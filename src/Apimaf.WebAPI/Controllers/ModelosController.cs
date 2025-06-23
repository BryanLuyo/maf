using Apimaf.Application.DTOs;
using Apimaf.Application.Services;
using Apimaf.Application.Utils;
using Microsoft.AspNetCore.Mvc;


namespace Apimaf.WebAPI.Controllers;

/// <summary>
/// Controlador para manejar sucursales.
/// </summary>
[ApiController]
[Route("marcas/{marcaId}/modelos")]
public class ModelosController : ControllerBase
{
    private readonly ModeloService _service;

    public ModelosController(ModeloService service)
    {
        _service = service;
    }

    // TODO: Devuelve los modelos de una marca
    [HttpGet]
    public async Task<ActionResult<ApiResponse<IEnumerable<ModeloDto>>>> Get(string  marcaId)
    {
        var decoded = UuidConverter.Decode(marcaId);
        var data = await _service.GetByMarcaIdAsync(decoded);
        return Ok(new ApiResponse<IEnumerable<ModeloDto>>(200, "successful operation", data));
    }
}
using Microsoft.AspNetCore.Mvc;
using Apimaf.Application.Services;
using Apimaf.Application.DTOs;

namespace Apimaf.WebAPI.Controllers;

/// <summary>
/// Controlador para manejar marcas.
/// </summary>
[ApiController]
[Route("marcas")]
public class MarcaController : ControllerBase
{
    private readonly MarcaService _service;

    public MarcaController(MarcaService service)
    {
        _service = service;
    }

    // TODO: Devuelve todas las marcas
    [HttpGet]
    public async Task<ActionResult<ApiResponse<IEnumerable<MarcaDto>>>> Get()
    {
        var data = await _service.GetAllAsync();
        return Ok(new ApiResponse<IEnumerable<MarcaDto>>(200, "successful operation", data));
    }
}
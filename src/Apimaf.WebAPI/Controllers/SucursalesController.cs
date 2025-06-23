using Microsoft.AspNetCore.Mvc;
using Apimaf.Application.Services;
using Apimaf.Application.DTOs;
using Apimaf.Application.Utils;
using System.Security.Claims;

namespace Apimaf.WebAPI.Controllers;

/// <summary>
/// Controlador para manejar sucursales.
/// </summary>
[ApiController]
[Route("concesionarios/{concesionarioId}/sucursales")]
public class SucursalesController : ControllerBase
{
    private readonly SucursalService _service;

    public SucursalesController(SucursalService service)
    {
        _service = service;
    }

    // TODO: Devuelve las sucursales de un concesionario
    [HttpGet]
     public async Task<ActionResult<ApiResponse<IEnumerable<SucursalDto>>>> Get(string concesionarioId)
    {
        var decoded = UuidConverter.Decode(concesionarioId);
        var data = await _service.GetByConcesionarioIdAsync(decoded);
        return Ok(new ApiResponse<IEnumerable<SucursalDto>>(200, "successful operation", data));
    }
}
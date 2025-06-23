using Apimaf.Application.DTOs;
using Apimaf.Domain.Entities;
using Apimaf.Domain.Interfaces;

namespace Apimaf.Application.Services;

/// <summary>
/// Servicio de aplicación para manejar concesionarios.
/// </summary>
public class ConcesionarioService
{
    private readonly IConcesionarioRepository _repository;

    public ConcesionarioService(IConcesionarioRepository repository)
    {
        _repository = repository;
    }

    // TODO: Devuelve todos los concesionarios como DTOs
    public async Task<IEnumerable<ConcesionarioDto>> GetAllAsync()
    {
        var items = await _repository.GetAllAsync();
        return items.Select(ConcesionarioDto.FromEntity);
    }

    // TODO: Crea un nuevo concesionario
    public async Task<int> CreateAsync(ConcesionarioDto dto)
    {
        var entity = new Concesionario
        {
            NomComercial = dto.NomComercial
        };
        await _repository.AddAsync(entity);
        await _repository.SaveChangesAsync();
        return entity.Id;
    }
}

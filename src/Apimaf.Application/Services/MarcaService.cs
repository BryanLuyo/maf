using Apimaf.Application.DTOs;
using Apimaf.Domain.Entities;
using Apimaf.Domain.Interfaces;

namespace Apimaf.Application.Services;

/// <summary>
/// Servicio de aplicación para manejar marcas.
/// </summary>
public class MarcaService
{
    private readonly IMarcaRepository _repository;

    public MarcaService(IMarcaRepository repository)
    {
        _repository = repository;
    }

    // TODO: Devuelve todos las marcas como DTOs
    public async Task<IEnumerable<MarcaDto>> GetAllAsync()
    {
        var items = await _repository.GetAllAsync();
        return items.Select(c => new MarcaDto(c.Id, c.NomComercial, c.Nombre));
    }

    // TODO: Crea una nueva marca
    public async Task<int> CreateAsync(MarcaDto dto)
    {
        var entity = new Marca
        {
            NomComercial = dto.NomComercial,
            Nombre = dto.Nombre
        };
        await _repository.AddAsync(entity);
        await _repository.SaveChangesAsync();
        return entity.Id;
    }
}

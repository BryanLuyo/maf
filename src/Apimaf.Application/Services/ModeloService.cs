using Apimaf.Application.DTOs;
using Apimaf.Domain.Entities;
using Apimaf.Domain.Interfaces;

namespace Apimaf.Application.Services;

/// <summary>
/// Servicio de aplicación para manejar modelos.
/// </summary>
public class ModeloService
{
    private readonly IModeloRepository _repository;

    public ModeloService(IModeloRepository repository)
    {
        _repository = repository;
    }

    // TODO: Obtiene las modelos por marca
    public async Task<IEnumerable<ModeloDto>> GetByMarcaIdAsync(int marcaId)
    {
        var items = await _repository.GetByMarcaIdAsync(marcaId);
        return items.Select(ModeloDto.FromEntity);
    }

    // TODO: Crea una nueva sucursal
    public async Task<int> CreateAsync(ModeloDto dto)
    {
        var entity = new Modelo
        {
            IdMarca = dto.IdMarca,
            Descripcion = dto.Descripcion
        };
        await _repository.AddAsync(entity);
        await _repository.SaveChangesAsync();
        return entity.Id;
    }
}

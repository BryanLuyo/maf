using Apimaf.Domain.Entities;

namespace Apimaf.Domain.Interfaces;

/// <summary>
/// Contrato para manejar los modelos.
/// </summary>
public interface IModeloRepository
{
    // TODO: Obtiene todos los modelos de una marca
    Task<IEnumerable<Modelo>> GetByMarcaIdAsync(int marcaId);

    // TODO: Crea un nuevo modelo
    Task AddAsync(Modelo entity);

    // TODO: Guarda los cambios
    Task SaveChangesAsync();
}

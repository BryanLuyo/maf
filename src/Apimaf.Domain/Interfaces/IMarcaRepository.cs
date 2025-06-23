using Apimaf.Domain.Entities;

namespace Apimaf.Domain.Interfaces;

/// <summary>
/// Contrato para manejar las marcas.
/// </summary>
public interface IMarcaRepository
{
    // TODO: Devuelve todos las marcas
    Task<IEnumerable<Marca>> GetAllAsync();

    // TODO: Busca una marca por id
    Task<Marca?> GetByIdAsync(int id);

    // TODO: Crea un nueva marca
    Task AddAsync(Marca entity);

    // TODO: Guarda los cambios
    Task SaveChangesAsync();
}

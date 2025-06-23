using Apimaf.Domain.Entities;
using Apimaf.Domain.Interfaces;
using Apimaf.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Apimaf.Infrastructure.Repositories;

/// <summary>
/// Implementación de repositorio de modelos usando EF Core.
/// </summary>
public class ModeloRepository : IModeloRepository
{
    private readonly ApplicationDbContext _context;

    public ModeloRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    // TODO: Obtiene todas los modelos de una marca
    public async Task<IEnumerable<Modelo>> GetByMarcaIdAsync(int marcaId)
        => await _context.Modelo.Where(s => s.IdMarca == marcaId).ToListAsync();

    // TODO: Crea un nuevo modelo
    public async Task AddAsync(Modelo entity)
        => await _context.Modelo.AddAsync(entity);

    // TODO: Guarda los cambios
    public async Task SaveChangesAsync()
        => await _context.SaveChangesAsync();
}

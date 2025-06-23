using Apimaf.Domain.Entities;
using Apimaf.Domain.Interfaces;
using Apimaf.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Apimaf.Infrastructure.Repositories;

/// <summary>
/// Implementación de repositorio de marcas usando EF Core.
/// </summary>
public class MarcaRepository : IMarcaRepository
{
    private readonly ApplicationDbContext _context;

    public MarcaRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    // TODO: Devuelve todos las marcas
    public async Task<IEnumerable<Marca>> GetAllAsync()
        => await _context.Marcas.AsNoTracking().ToListAsync();

    // TODO: Busca una marca por id
    public async Task<Marca?> GetByIdAsync(int id)
        => await _context.Marcas.FindAsync(id);

    // TODO: Crea una nueva marca
    public async Task AddAsync(Marca entity)
        => await _context.Marcas.AddAsync(entity);

    // TODO: Guarda los cambios
    public async Task SaveChangesAsync()
        => await _context.SaveChangesAsync();
}

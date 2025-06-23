using Apimaf.Application.Utils;
namespace Apimaf.Application.DTOs;

/// <summary>
/// DTO para exponer datos del Modelo.
/// </summary>
public record ModeloDto(string Id, int IdMarca, string Descripcion)
{
    public static ModeloDto FromEntity(Apimaf.Domain.Entities.Modelo entity)
        => new(
            UuidConverter.Encode(entity.Id),
            entity.IdMarca,
            entity.Descripcion ?? string.Empty);
}

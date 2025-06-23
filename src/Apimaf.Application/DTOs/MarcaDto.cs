namespace Apimaf.Application.DTOs;
using Apimaf.Application.Utils;

/// <summary>
/// DTO para exponer datos de la Marca.
/// </summary>
public record MarcaDto(string Id, string NomComercial)
{
    public static MarcaDto FromEntity(Apimaf.Domain.Entities.Marca entity)
        => new(
            UuidConverter.Encode(entity.Id),
            entity.NomComercial ?? string.Empty);
}

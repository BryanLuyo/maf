namespace Apimaf.Application.DTOs;
using Apimaf.Application.Utils;
/// <summary>
/// DTO para exponer datos de la Concesionario.
/// </summary>
public record ConcesionarioDto(string Id, string NomComercial)
{
    public static ConcesionarioDto FromEntity(Apimaf.Domain.Entities.Concesionario entity)
        => new(UuidConverter.Encode(entity.Id).ToString(), entity.NomComercial);
}
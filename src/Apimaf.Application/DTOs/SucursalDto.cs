namespace Apimaf.Application.DTOs;
using Apimaf.Application.Utils;

/// <summary>
/// DTO para exponer datos de la Sucursal.
/// </summary>
public record SucursalDto(string Id, int IdConcesionario, string DescNombre, string DescDireccion, string DescCod)
{
    public static SucursalDto FromEntity(Apimaf.Domain.Entities.Sucursal entity)
        => new(UuidConverter.Encode(entity.Id).ToString(), entity.IdConcesionario, entity.DescNombre, entity.DescDireccion, entity.DescCod);
}

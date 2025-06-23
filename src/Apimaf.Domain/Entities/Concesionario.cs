namespace Apimaf.Domain.Entities;

/// <summary>
/// Entidad principal de un concesionario de autos.
/// </summary>
public class Concesionario
{
    public int Id { get; set; }
    public string NomComercial { get; set; } = string.Empty;
    public int FlgEstado { get; set; } = 1;
    public DateTime? CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }

    // TODO: Lista de sucursales asociadas al concesionario
    public ICollection<Sucursal> Sucursales { get; set; } = new List<Sucursal>();
}

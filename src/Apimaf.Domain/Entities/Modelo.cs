namespace Apimaf.Domain.Entities;

/// <summary>
/// Representa una sucursal del concesionario.
/// </summary>
public class Modelo
{
    public int Id { get; set; }
    public int IdMarca { get; set; }
    public string NomComercial { get; set; } = string.Empty;
    public string? Descripcion { get; set; }
    public int FlgEstado { get; set; } = 1;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedAt { get; set; } = DateTime.UtcNow;

    // TODO: Propiedad de navegación a la marca
    public Marca? Marca { get; set; }
}

namespace Apimaf.Domain.Entities;

/// <summary>
/// Representa una sucursal del concesionario.
/// </summary>
public class Modelo
{
    public int Id { get; set; }
    public int IdMarca { get; set; }
    public string? Descripcion { get; set; }
    public int FlgEstado { get; set; } = 1;
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }

    // TODO: Propiedad de navegación a la marca
    public Marca? Marca { get; set; }
}

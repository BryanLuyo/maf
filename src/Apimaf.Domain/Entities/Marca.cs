namespace Apimaf.Domain.Entities;

/// <summary>
/// Entidad principal de un concesionario de autos.
/// </summary>
public class Marca
{
    public int Id { get; set; }
    public string NomComercial { get; set; } = string.Empty;
    public string Nombre { get; set; } = string.Empty;
    public string? Descripcion { get; set; }
    public int FlgEstado { get; set; } = 1;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedAt { get; set; } = DateTime.UtcNow;

    // TODO: Lista de sucursales asociadas al modelo
    public ICollection<Modelo> Modelos { get; set; } = new List<Modelo>();
}

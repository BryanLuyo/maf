namespace Apimaf.Domain.Entities;

/// <summary>
/// Representa una sucursal del concesionario.
/// </summary>
public class Sucursal
{
    public int Id { get; set; }
    public int IdConcesionario { get; set; }
    public string? DescNombre { get; set; } = string.Empty;
    public string? DescCod { get; set; } = string.Empty;
    public string? DescDireccion { get; set; } = string.Empty;
    public int FlgEstado { get; set; } = 1;
    public DateTime? CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }

    // TODO: Propiedad de navegación al Concesionario
    public Concesionario? Concesionario { get; set; }
}

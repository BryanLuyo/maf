namespace Apimaf.Application.Utils;

/// <summary>
/// Utilidad para convertir IDs enteros en cadenas UUID de forma reversible.
/// </summary>
public static class UuidConverter
{
    // Sufijo fijo para formar el UUID de salida.
    private const string Suffix = "e89b-12d3-a456-426655440000";

    /// <summary>
    /// Codifica el entero en un UUID determinista con el formato
    /// "XXXXXXXX-e89b-12d3-a456-426655440000".
    /// </summary>
    public static string Encode(int id)
    {
        return $"{id:X8}-{Suffix}";
    }

    /// <summary>
    /// Decodifica el UUID generado por <see cref="Encode"/> y devuelve
    /// el valor entero original.
    /// </summary>
    public static int Decode(string uuid)
    {
        var hex = uuid.Substring(0, 8);
        return int.Parse(hex, System.Globalization.NumberStyles.HexNumber);
    }
}
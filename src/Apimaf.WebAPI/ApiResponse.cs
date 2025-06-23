namespace Apimaf.WebAPI;

/// <summary>
/// Contenedor estándar para las respuestas de la API.
/// </summary>
/// <typeparam name="T">Tipo de la propiedad Data.</typeparam>
public record ApiResponse<T>(int Status, string Message, T? Data);
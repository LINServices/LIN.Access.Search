namespace LIN.Access.Search.Controllers;

public static class Search
{

    /// <summary>
    /// Obtener información de una pelicula.
    /// </summary>
    /// <param name="term">Termino de búsqueda.</param>
    public static async Task<ReadOneResponse<LIN.Types.Exp.Search.Models.Movie>> Movie(string term)
    {

        // Cliente.
        Client client = Service.GetClient("movies");

        // Parámetros.
        client.AddParameter("movie", term);

        // Respuesta.
        var response = await client.Get<ReadOneResponse<LIN.Types.Exp.Search.Models.Movie>>();

        return response;
    }


    /// <summary>
    /// Buscar en general.
    /// </summary>
    /// <param name="term">Termino de búsqueda.</param>
    public static async Task<ReadAllResponse<LIN.Types.Exp.Search.Models.SearchResult>> Get(string term)
    {

        // Cliente.
        Client client = Service.GetClient("search");

        // Parámetros.
        client.AddParameter("query", term);

        // Respuesta.
        var response = await client.Get<ReadAllResponse<LIN.Types.Exp.Search.Models.SearchResult>>();

        return response;
    }

}
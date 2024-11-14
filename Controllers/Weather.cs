namespace LIN.Access.Search.Controllers;

public static class Weather
{

    /// <summary>
    /// Buscar.
    /// </summary>
    /// <param name="city">Ciudad.</param>
    public static async Task<ReadOneResponse<LIN.Types.Exp.Search.Models.Weather>> Get(string city)
    {

        // Cliente.
        Client client = Service.GetClient("weather");

        // Parámetros.
        client.AddParameter("city", city);

        // Respuesta.
        var response = await client.Get<ReadOneResponse<LIN.Types.Exp.Search.Models.Weather>>();

        return response;
    }

}
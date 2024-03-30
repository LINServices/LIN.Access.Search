using LIN.Access.Search;
using Global.Http.Services;
using LIN.Types.Responses;
using System.Threading.Tasks;

namespace LIN.Access.Search.Controllers;


public static class Weather
{


  
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
using LIN.Access.Search;
using Global.Http.Services;
using LIN.Types.Responses;
using System.Threading.Tasks;

namespace LIN.Access.Search.Controllers;


public static class Search
{


  
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
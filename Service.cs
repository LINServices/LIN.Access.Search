namespace LIN.Access.Search;


internal class Service
{

    /// <summary>
    /// Servicio.
    /// </summary>

    public static Access.Service _Service = new();



    /// <summary>
    /// Obtener un cliente.
    /// </summary>
    public static Services.Client GetClient(string url) => _Service.GetClient(url);


}
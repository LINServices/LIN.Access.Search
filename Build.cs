namespace LIN.Access.Search;


public class Build
{

    public static void Init()
    {
        Service._Service = new();
        Service._Service.SetDefault("http://api.search.linapps.co/");
    }

}
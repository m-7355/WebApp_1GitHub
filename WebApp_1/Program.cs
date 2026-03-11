using WebApp_1.WebConnect;

class Program
{

    public static void Main(string[] args)
    {
        var app = new WebApp_1.WebConnect.Webapp().Create(args);
        app.Run();
    }
}
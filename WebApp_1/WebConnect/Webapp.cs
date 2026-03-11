
namespace WebApp_1.WebConnect
{
    public class Webapp
    {
        // webに接続
        public WebApplication Create(string[] args)
        {
            var builder = WebApplication.CreateBuilder();
            var app = builder.Build();

            // ここで好きな URL を作る
            app.MapGet("/hello", () => "Hello World!");
            app.MapPost("/api/start", () => Results.Ok("start OK"));
            app.MapPost("/api/end", () => Results.Ok("end OK"));
            app.MapGet("/api/status", () => "status OK");

            return app;
        }
    }
}

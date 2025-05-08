
namespace _1HelloWorld
{
    class HWWebApp
    {
        static void main(String[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();
            app.MapGet("/", () => "Hello, World!");
            app.Run();
        }
    }
}
